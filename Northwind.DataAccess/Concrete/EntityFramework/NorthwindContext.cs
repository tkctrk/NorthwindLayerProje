using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    

    public class NorthwindContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //DB GONDERMIS OLDUGUMUZ TABLE ISIMLERINDE S TAKISI OLMASINI ISTEMIYORSAM BUNU KULLANIYORUM...
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Kategoriler> Kategoriler { get; set; }
        public DbSet<Urunler> Urunler { get; set; }
    }
}
