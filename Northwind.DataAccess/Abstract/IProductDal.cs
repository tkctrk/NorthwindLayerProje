using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Urunler>
    {
        //BURADA HERHANGI BIR OPERASYON YAZMAYCAGIZ ISTERSEK JOIN ISLEMLERINIZ BURADA YAZABILIRIZ. DAL => DATA ACCES LAYER DEMEKTIR.
    }
}
