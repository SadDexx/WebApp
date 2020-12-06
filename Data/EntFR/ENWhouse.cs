using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Model;

namespace WebApp.Data.EntFR
{
    public class ENWhouse
    {
        private readonly AppDBConnect context;

        public ENWhouse(AppDBConnect context)
        {
            this.context = context;
        }
        public IEnumerable<mWarehouse> GetAllItem()
        {
            return context.Warehouses;
        }
        public mWarehouse GetENWhouseById(Guid id)
        {
            return context.Warehouses.Single(x => x.wID == id);
        }
        public Guid SaveWhouse(mWarehouse gIDv)
        {
            if (gIDv.wID == default) // Если такой записи нет то создаем
                context.Entry(gIDv).State = EntityState.Added;
           
            else // Если есть то модифицируем
                context.Entry(gIDv).State = EntityState.Modified;
            context.SaveChanges();

            return gIDv.wID;
        }


        public void DeleteWhouse(mWarehouse gIDv)
        {
            context.Warehouses.Remove(gIDv);
            context.SaveChanges();
        }
    }
}
