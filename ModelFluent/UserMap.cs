using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelFluent
{
   public class UserMap:AbstractValidator<Usuario>
    {

        public UserMap()
        {
            RuleFor(u => u.Nome)
                .NotNull()
                .NotEmpty()
                .WithMessage("Please ensure that you have entered your Surname")
                .Matches("[A-Z]").WithMessage("sdfasdf asdf asfsa fsd fsaf asdfsd ");

        }

    }
}
