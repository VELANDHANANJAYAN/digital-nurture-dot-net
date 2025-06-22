using System;
using System.Linq;

namespace ECommerceSearchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product(1, "Laptop", "Electronics"),
                new Product(2, "Shirt", "Clothing"),
                new Product(3, "Phone", "Electronics"),
                new Product(4, "Shoes", "Footwear"),
                new Product(5, "Watch", "Accessories")
            };

            string target = "Phone";

            Product linearResult = SearchEngine.LinearSearch(products, target);
            Console.WriteLine(linearResult != null ? $"Linear: {linearResult.ProductName} found." : "Linear: Not found.");

            Product[] sortedProducts = products.OrderBy(p => p.ProductName).ToArray();
            Product binaryResult = SearchEngine.BinarySearch(sortedProducts, target);
            Console.WriteLine(binaryResult != null ? $"Binary: {binaryResult.ProductName} found." : "Binary: Not found.");
        }
    }
}
