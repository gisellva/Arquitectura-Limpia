using ARQUITECTURAS.SOLID;

namespace ARQUITECTURAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Category electronicsCategory = new Category("electronicsCategory",2.1m,12,"categoria de electtronica");
            Product producto1=new Product("Laptop", 1500, electronicsCategory);
            producto1.GetPrpduct();
            
        }
    }
}
