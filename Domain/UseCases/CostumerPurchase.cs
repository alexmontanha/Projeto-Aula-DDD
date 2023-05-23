using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.ValueObjects;

namespace Domain.UseCases
{
    public class CostumerPurchase
    {
        //As a costumer I want to buy a product
        //So that I can have it
        public int EnterpriseCode { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public void BuyProduct(Costumer costumer, Product product, int quantity, InventoryControl inventoryControl,
                                    List<Product> availProducts)
        {
            if (!availProducts.Contains(product))
            {
                throw new Exception("Product is not available");
            }

            if (quantity > inventoryControl.ProductCount())
            {
                throw new Exception("There is not enough products in stock");
            }

            inventoryControl.RemoveProduct(product);

        }
    }
}
