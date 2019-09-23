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
            int[] reversedArray = new int[productId.Length];

            for (int i = 0; i <= productId.Length - 1; i++)
            {
                reversedArray[i] = productId[productId.Length - i - 1];
            }

            return reversedArray;
        }

        public int[] DeletePart(int position, int[] productId)
        {
            try
            {
                int[] responseArray = new int[productId.Length - 1];
                int productIdIndex = 0;
                for (int i = 0; i < productId.Length; i++)
                {
                    if (i != (position - 1))
                    {
                        responseArray[productIdIndex] = productId[i];
                        productIdIndex = productIdIndex + 1;
                    }

                }

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
