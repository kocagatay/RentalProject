using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validationrules.FluentValidation
{
    public class ColorValidation : AbstractValidator<Color>
    {
        public ColorValidation()
        {
            RuleFor(co => co.ColorId).NotEmpty();
            RuleFor(co => co.ColorName).NotEmpty();
        }
    }
}
