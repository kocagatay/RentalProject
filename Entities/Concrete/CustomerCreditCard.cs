using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CustomerCreditCard : IEntity
    {
        [Key]
        public int CustomerCardId { get; set; }
        public int CustomerId { get; set; }
        public int CreditCardId { get; set; }
    }
}
