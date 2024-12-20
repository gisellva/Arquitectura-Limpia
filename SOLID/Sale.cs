using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARQUITECTURAS.SOLID
{
    public class Sale
    {
        private List<Product> ProductList = new List<Product>();
        public DateTime SaleDate { get; }
        public decimal DiscountPercentege { get; }

        public Sale(decimal discountPercentage = 0)
        {
            SaleDate = DateTime.Now; 
            DiscountPercentege = discountPercentage;
        }

        public void AddProduct(Product product)
        {
         ProductList.Add(product);
        }
        public void RemoveProduct(Product product) 
        {
        ProductList.Remove(product);
        }

        public decimal CalculateTotal( )
        { 
         decimal total=ProductList.Sum(x=>x.Price);
            if (DiscountPercentege > 0)
            {
                total -= total * (DiscountPercentege / 100);
            }

            return total;
        }
        public void ShowSaleDetails()
        {
            Console.WriteLine($"Sale Date: {SaleDate}");
            Console.WriteLine("Products in the Sale:");
            foreach (var product in ProductList)
            {
                Console.WriteLine($" - {product.Name}: ${product.Price}");
            }
            Console.WriteLine($"Discount: {DiscountPercentege}%");
            Console.WriteLine($"Total: ${CalculateTotal()}");
        }
    }

}
