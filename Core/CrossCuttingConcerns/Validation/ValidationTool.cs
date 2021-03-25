using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,object entity)
        {
            var context = new ValidationContext<object>(entity);//ben product için bir doğrulama yapacağım
            var result = validator.Validate(context);//validator kuralları için ilgili contexti yani entityi doğrula demek.
            if (!result.IsValid)//eğer sonuç geçerli değilse hata fırlat.
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
