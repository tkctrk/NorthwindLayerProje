using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        //FUNC : BIR DELEGEDIR.METOTLARI TEMSIL EDER BIZ BURADA GELEN DATAYI LAMBDA EXPRESSŞON KULLANMAK ICIN EXPRESSİON KULLANMAK ICIN WHERE.(X=>X.URUNID==5) BUNU YAZMAK ICIN Expression<Func<T,bool>> predicate BUNU KULLANIYORUZ
        List<T> GetAll(Expression<Func<T,bool>> predicate=null);//WHERE.(X=>X.URUNID==5)
        T get(Expression<Func<T, bool>> predicate);//URUN IDSINE GORE SORGULAMA YAPAR
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
