using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules
{
    public class ProductValidator : AbstractValidator<Urunler>
    {
        //BURADA KOMUTLARIMIZI YAZIYORUZ VE KULLANCIIYA MESAJ GÖNDERIYORUZ..
        public ProductValidator()
        {
            RuleFor(x => x.UrunAdi).NotEmpty();
            RuleFor(x=>x.BirimdekiMiktar).NotEmpty().WithMessage("Lütfen Birimdeki Miktar Değerini Giriniz");
            RuleFor(x=>x.BirimFiyati).NotEqual(0);
            RuleFor(x=>x.HedefStokDuzeyi).NotEmpty().WithMessage("Hedef Stok Düzeyi Boş Olamaz");
        }
    }
}
