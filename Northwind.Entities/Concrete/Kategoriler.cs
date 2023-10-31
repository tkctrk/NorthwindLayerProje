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
    [Table("Kategoriler")]
    public class Kategoriler : IEntity
    {
        [Key]
        public int KategoriId { get; set; }        
        public string KategoriAdi { get; set; }
        public string Tanimi { get; set; }
    }
}
