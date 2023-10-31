using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        //IPRODUCTDAL NESNESINI READONYL YAPMAMIZIN SEBEBI SADECE OKUNABILIR OLMASIDIR.VE BU SADECE CLASS ICERISINDE OKUNABILIR OLMALIDIR..
        private readonly IProductDal _productdal;

        public ProductManager(IProductDal productdal)
        {
            _productdal = productdal;
        }

        public void Add(Urunler urunler)
        {
            _productdal.Add(urunler);
        }

        public void Delete(Urunler urunler)
        {
           _productdal.Delete(urunler);
        }

        public List<Urunler> GetAll()
        {
           return _productdal.GetAll();
        }

        public List<Urunler> GetProductByCategory(int id)
        {
           return _productdal.GetAll(x => x.KategoriID.Equals(id));
        }

        public List<Urunler> GetProducts(string productname)
        {
         return _productdal.GetAll(x =>x.UrunAdi.Contains(productname));
        }

        public void Update(Urunler urunler)
        {
            _productdal.Update(urunler);
        }
    }
}
