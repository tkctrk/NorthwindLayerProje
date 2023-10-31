using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Utilities
{
    public class ValidationTools
    {
        public static void Validate<T>(IValidator<T> validator, T value)
        {
            var validationResult = validator.Validate(value);
            if (validationResult.Errors.Count>0)
            {
                throw new ValidationException(validationResult.Errors); //HATA FIRLATMA 
            }
        }
    }
}
