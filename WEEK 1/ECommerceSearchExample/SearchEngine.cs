using System;
using System.Collections.Generic;

namespace ECommerceSearchExample
{
    public class SearchEngine
    {
        public static Product LinearSearch(Product[] products, string target)
        {
            foreach (var product in products)
            {
                if (product.ProductName == target)
                {
                    return product;
                }
            }
            return null;
        }

        public static Product BinarySearch(Product[] products, string target)
        {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int compare = string.Compare(products[mid].ProductName, target, StringComparison.OrdinalIgnoreCase);
                if (compare == 0)
                    return products[mid];
                else if (compare < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return null;
        }
    }
}
