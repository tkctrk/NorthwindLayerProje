using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Kategoriler>  GetAll(); //GETALL HEPSİNİ ÇEK HEPSİNİ AL DEMEK.
        void Add(Kategoriler kategoriler);
        void Update(Kategoriler kategoriler);
        void Delete(Kategoriler kategoriler);
    }
}
