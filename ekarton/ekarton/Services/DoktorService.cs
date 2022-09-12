using AutoMapper;
using ekarton.Databases;
using ekarton.ML;
using ekarton.Model.Request;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Trainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Services
{
    public class DoktorService:IDoktorService
    {
        private readonly IMapper _mapper;
        private readonly rekartonContext Context;
        static MLContext mLContext = null;
        static ITransformer model = null;
        public DoktorService(rekartonContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }

        public IEnumerable<Model.Models.Doktor> Get(DoktorSearchRequest search)
        {
            var query = Context.Doktors.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.ImeDoktor))
            {
                query = query.Where(x => x.Ime.ToLower().StartsWith(search.ImeDoktor.ToLower()));
            }
            if(search?.IncludeOdjel==true)
            {
                query = query.Include(x => x.Odjel);
            }
            if(!string.IsNullOrWhiteSpace(search?.NazivOdjela))
            {
                query = query.Where(x => x.Odjel.Naziv == search.NazivOdjela);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Models.Doktor>>(list);
        }
        public Model.Models.Doktor GetById(int id)
        {
            var entity = Context.Doktors.Find(id);
            return _mapper.Map<Model.Models.Doktor>(entity);
        }
        public void Insert(DoktorInsertRequest request)
        {
            Databases.Doktor entity = _mapper.Map<Databases.Doktor>(request);

            Context.Doktors.Add(entity);
            Context.SaveChanges();
        }

        public List<Model.Models.Doktor> Recommender(int id)
        {
            if(mLContext==null)
            {
                mLContext = new MLContext();
                var tmpData = Context.Doktors.Include(x => x.DodjeljeniDoktors).ToList();
                var data = new List<ProductEntry>();
                foreach(var x in tmpData)
                {
                    if(x.DodjeljeniDoktors.Count()>1)
                    {
                        var disticntItemId = x.DodjeljeniDoktors.Select(x => x.DoktorId).ToList();
                        disticntItemId.ForEach(y =>
                        {
                            var relatedItems = x.DodjeljeniDoktors.Where(z => z.DoktorId != y).ToList();
                            relatedItems.ForEach(z =>
                            {
                                data.Add(new ProductEntry() { ProductId = (uint)y, CoPurchaseProductID = (uint)z.DoktorId });
                            });
                        });

                    }
                }
                var traindata = mLContext.Data.LoadFromEnumerable(data);

                MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options();
                options.MatrixColumnIndexColumnName = nameof(ProductEntry.ProductId);
                options.MatrixRowIndexColumnName = nameof(ProductEntry.CoPurchaseProductID);
                options.LabelColumnName = "Label";
                options.LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass;
                options.Alpha = 0.01;
                options.Lambda = 0.025;
                options.C = 0.00001;


                var est = mLContext.Recommendation().Trainers.MatrixFactorization(options);

                 model = est.Fit(traindata);

            }
            var allItems = Context.Doktors.Where(x => x.DoktorId != id).ToList();
            var predictionResult = new List<Tuple<Databases.Doktor, float>>();

            foreach (var item in allItems)
            {

                var predictonengine = mLContext.Model.CreatePredictionEngine<ProductEntry, Copurchase_prediction>(model);
                var prediction = predictonengine.Predict(new ProductEntry() { ProductId = (uint)id, CoPurchaseProductID = (uint)item.DoktorId });
                predictionResult.Add(new Tuple<Doktor, float>(item, prediction.Score));


            
            }
            var finalResult = predictionResult.OrderByDescending(x => x.Item2).Take(3).Select(x => x.Item1).ToList();
            return _mapper.Map<List<Model.Models.Doktor>>(finalResult);

        }

        public void Update(int id, DoktorUpdateRequest request)
        {
            var entity = Context.Doktors.Where(x => x.DoktorId == id).FirstOrDefault();
            Context.Doktors.Attach(entity);
            Context.Doktors.Update(entity);
            _mapper.Map(request, entity);

            Context.SaveChanges();
        }
    }
}
