﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validationrules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
           // RuleFor(c => c.BrandId).NotEmpty();
           // RuleFor(c => c.ColorId).NotEmpty();
           // RuleFor(c => c.ModelYear).NotEmpty();
           // RuleFor(c => c.DailyPrice).NotEmpty();
           // RuleFor(c => c.ModelName).NotEmpty();
           // RuleFor(c => c.Description).MinimumLength(4);
        }
    }
}
