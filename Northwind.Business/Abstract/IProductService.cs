using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Urunler> GetAll();
        List<Urunler> GetProductByCategory(int id);
        List<Urunler> GetProducts(string productname);
        void Add(Urunler urunler);
        void Update(Urunler urunler);
        void Delete(Urunler urunler);


    }
}
