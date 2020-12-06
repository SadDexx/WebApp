using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Model;

namespace WebApp.Data.EntFR
{
    public class ENGoods
    {
        private readonly AppDBConnect context;

        public ENGoods(AppDBConnect context)
        {
            this.context = context;
        }
        public IEnumerable<mGoods> GetAllItem()
        {
            return context.Goods;
        }
        public mGoods GetENGoodsById(Guid id)
        {
            return context.Goods.Single(x => x.GID == id);
        }
        public Guid SaveGoods(mGoods gIDv)
        {
            if (gIDv.GID == default) // Если такой записи нет то создаем
                context.Entry(gIDv).State = EntityState.Added;
           
            else // Если есть то модифицируем
                context.Entry(gIDv).State = EntityState.Modified;
            context.SaveChanges();

            return gIDv.GID;
        }


        public void DeleteGoods(mGoods gIDv)
        {
            context.Goods.Remove(gIDv);
            context.SaveChanges();
        }
    }
}
