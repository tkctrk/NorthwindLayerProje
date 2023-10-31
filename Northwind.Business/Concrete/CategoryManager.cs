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
    public class CategoryManager : ICategoryService
    {
         private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Kategoriler kategoriler)
        {
            _categoryDal.Add(kategoriler);
        }

        public void Delete(Kategoriler kategoriler)
        {
           _categoryDal.Delete(kategoriler);
        }

        public List<Kategoriler> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Update(Kategoriler kategoriler)
        {
            _categoryDal.Update(kategoriler);
        }
    }
}
