using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.ValueObjects
{
    public class Purchase
    {
        public int EnterpriseCode { get; set; }
        public int PurchaseId { get; set; }
        public int CostumerId { get; set; }
        public Invoice? Invoice { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
