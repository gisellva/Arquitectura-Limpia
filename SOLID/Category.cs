using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARQUITECTURAS.SOLID
{
   public class Category
    {
     public string Name { get; set; }
     public int IDCtaregory { get; set; }
     public decimal DiscountPercentage { get; }
     public string Description { get; set; }

     public Category(string name, decimal discountPercentage, int IdCategory,string description)
     {
            Name = name;
            DiscountPercentage = discountPercentage;
            IDCtaregory = IdCategory;
            Description = description;
     }
        public void ShowDetails()
        {
            Console.WriteLine($"ID: {IDCtaregory}, Name: {Name}, Discount: {DiscountPercentage}%");
        }

    }
}
