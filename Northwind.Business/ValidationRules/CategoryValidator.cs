using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Kategoriler>
    {
            //BURADA KOMUTLARIMIZI YAZIYORUZ VE KULLANCIIYA MESAJ GÖNDERIYORUZ..
            public CategoryValidator()
            {
                RuleFor(x => x.KategoriAdi).NotEmpty().WithMessage("Kategori Adı Boş Bırakılamaz");
                RuleFor(x => x.Tanimi).NotEmpty().Length(50).WithMessage("Açıklama Boş Bırakılamaz Maksimum 50 Karakter Olmalıdır.");            
            }
    }
}
