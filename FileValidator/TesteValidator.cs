using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels;

namespace FileValidator
{
   public class TesteValidator:AbstractValidator<UserDTO>
    {
        public TesteValidator()
        {
           
            RuleFor(u => u.ID)
                .GreaterThan(0)
                .WithMessage("{PropertyName} Numero {PropertyValue} é menor que Zero")
                .NotEmpty()
                .NotNull().WithMessage("{PropertyName} Ñão Pode ser Vazia ou Nula");

            RuleFor(u => u.Name)
               .NotEmpty()
               .NotNull().WithMessage("{PropertyName} Ñão Pode ser Vazia ou Nula");

            RuleFor(u => u.DateOfBirth)
               .GreaterThan(DateTime.Now.AddDays(-7))
               .WithMessage("Campo:{PropertyName} A Data {PropertyValue}  não pode ser maior que a data Atual.");
        }
    }
}
