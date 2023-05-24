using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validationrules.FluentValidation
{
    public class CustomerValidation : AbstractValidator<Customer>
    {
        public CustomerValidation()
        {
            RuleFor(c => c.UserId).NotEmpty();
            RuleFor(c => c.CompanyName).NotEmpty();
        }
    }
}
