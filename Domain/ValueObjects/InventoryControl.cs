using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.ValueObjects
{
    public class InventoryControl
    {
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        public int ProductCount()
        {
            return Products.Count;
        }

        public int EnterpriseCode { get; set; }
        public int InventoryControlId { get; set; }
        public Inventory Inventory { get; set; }
        public List<Product> Products { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
