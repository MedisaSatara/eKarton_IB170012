using ekarton.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Services
{
    public class SetupService
    {
        public void Init(rekartonContext context)
        {
            //context.Database.Migrate();

            ////add new new data or update data
            //if (!context.JediniceMjeres.Any(x => x.Naziv == "Test"))
            //{
            //    context.JediniceMjeres.Add(new JediniceMjere() { Naziv = "Test" });
            //}

            //context.SaveChanges();
        }
    }
}
