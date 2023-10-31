using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entities.Concrete
{
    [Table("Urunler")]
    public class Urunler:IEntity
    {
        [Key]
        public int UrunId { get; set; } //KEY : DB ILETISIM KURULDUGUNDA BURANIN BIR PRIMARY KEY ALAN OLDUGUNU COZUMLEYECEKTIR.
        public string UrunAdi { get; set; }
        public int? KategoriID { get; set; }// ? IFADESI NULL YANI BOS GECIBLEBILIR ALAN OLACAGI ANLAMINA GELIR.
        public decimal BirimFiyati { get; set; }
        public short HedefStokDuzeyi { get; set; }
        public string BirimdekiMiktar { get; set; }

        Kategoriler kt = new Kategoriler();
    }
}
