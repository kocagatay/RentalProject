using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CustomerCreditCardsDetailDto : IDto
    {
        public int CustomerCardId { get; set; }
        public int UserId { get; set; }
        public int CardId { get; set; }
    }
}
