using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Databases
{
    public class Data
    {
        public static void Seed(rekartonContext context)
        {
            context.Database.Migrate();
        }
    }
}
