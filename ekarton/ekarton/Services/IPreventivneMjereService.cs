using ekarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Services
{
    public interface IPreventivneMjereService
    {
        IEnumerable<Model.Models.PreventivneMjere> Get(PreventivneMjereSearchRequest request=null);
        Model.Models.PreventivneMjere GetById(int Id);
    }
}
