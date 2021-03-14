using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            //Buraya renk ile ilgili kurallar yazılacak
            RuleFor(c => c.ColorName).NotEmpty();
            RuleFor(c => c.ColorName).MinimumLength(2);
        }
    }
}
