using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARQUITECTURAS.SOLID
{
    public class Product
    {
        public int IDProduct { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }

       public Product(string name,int price, Category category)
        {
            Name = name;
            Price = price;
            Category = category;

        }
        public int GetPrice() => Price;
        public void GetPrpduct() 
        {
           
            Console.WriteLine
                (
                $"ID del producto: {IDProduct}, Nombre del producto:{Name} ,Precio del producto:{Price},Categoria del producto:{Category}"
              

                );
        }
    }
}
