using calculator.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculator.Domain.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public int[] Reverse(int[] productId)
        {
            //int[] productId = new int[] { 1, 2, 3, 4, 5 };
            int[] reversedArray = new int[productId.Length];

            for (int i = 0; i <= productId.Length - 1; i++)
            {
                reversedArray[i] = productId[productId.Length - i - 1];
            }
            Console.WriteLine(string.Join(",", reversedArray));
            Console.WriteLine(string.Join(",", productId));

            return reversedArray;
        }

        public int[] DeletePart(int position, int[] productId)
        {
            try
            {
                //int position = 3;
                //int[] productId = new int[] { 1, 2, 3, 4, 5 };
                Console.WriteLine(productId.Length);
                int[] responseArray = new int[productId.Length - 1];
                Console.WriteLine(responseArray.Length);
                int productIdIndex = 0;
                for (int i = 0; i < productId.Length; i++)
                {
                    Console.WriteLine(i + " " + productIdIndex);
                    if (i != (position - 1))
                    {
                        responseArray[productIdIndex] = productId[i];
                        Console.WriteLine("responseArray " + string.Join(",", responseArray));
                        productIdIndex = productIdIndex + 1;
                    }

                }

                Console.WriteLine("responseArray final " + string.Join(",", responseArray));
                return responseArray;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception at: " + ex.StackTrace);
                return null;
            }

        }
    }
}
