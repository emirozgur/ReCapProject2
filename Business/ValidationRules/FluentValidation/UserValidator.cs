using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            //Buraya kullanıcı ile ilgili kurallar yazılacak
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.PassWord).NotEmpty();
        }
    }
}
