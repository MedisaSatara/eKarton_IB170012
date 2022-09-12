﻿using ekarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Services
{
    public interface IPregledService
    {
        IEnumerable<Model.Models.Pregled> Get(PregledSearchRequest request = null);
        Model.Models.Pregled GetById(int id);
    }
}
