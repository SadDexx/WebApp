using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Model;

namespace WebApp.Data
{
    public class AppDBConnect : IdentityDbContext<IdentityUser>
    {
        public AppDBConnect(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<mGoods> Goods { get; set; }
        public DbSet<mWarehouse> Warehouses { get; set; }
    }
}
