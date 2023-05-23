using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Invoice
    {
        public int EnterpriseCode { get; set; }
        public int InvoiceId { get; set; }
        public Costumer Costumer { get; set; }
        public List<Product> Products { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
