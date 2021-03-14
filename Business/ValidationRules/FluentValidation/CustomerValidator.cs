using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            //Buraya Müşteri ile ilgili kurallar yazılacak
            RuleFor(c => c.CompanyName).NotEmpty();
            RuleFor(c => c.UserId).NotEmpty();
            RuleFor(c => c.UserId).NotEqual(0);
        }
    }
}
