using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            //Buraya kiralamaa ile ilgili kurallar yazılacak
            RuleFor(r => r.CarId).NotNull();
            RuleFor(r => r.CustomerId).NotNull();
            RuleFor(r => r.RentDate).NotNull();
        }
    }
}
