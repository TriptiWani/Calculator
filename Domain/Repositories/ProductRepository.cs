using calculator.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculator.Domain.Repositories
{
    public class ProductRepository : IProductRepository
    {
        /// <summary>
        /// Reverse the array using array manipulations only
        /// o	Condition
        /// 	Implement with pure array manipulation
        // 	Don’t use Array.reverse() method
        // 	Don’t use Linq
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public int[] Reverse(int[] productId)
        {
            int[] reversedArray = new int[productId.Length];

            //Traversing the array and adding to the reversedArray.
            for (int i = 0; i <= productId.Length - 1; i++)
            {
                reversedArray[i] = productId[productId.Length - i - 1];
            }

            return reversedArray;
        }

        /// <summary>
        /// Delete the integer present at the position mentioned using pure array manipulation
        /// o	Condition
        // 	Implement with pure array manipulation
        // 	Don’t use RemoveAt
        // 	Don’t use Linq
        /// </summary>
        /// <param name="position"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        public int[] DeletePart(int position, int[] productId)
        {
            try
            {
                int[] responseArray = new int[productId.Length - 1];
                //Index to add the integer to the response Array
                int productIdIndex = 0;
                for (int i = 0; i < productId.Length; i++)
                {
                    //if the input array index does not match the position, add to the response array.
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
                //catch exceptions if any.
                Console.WriteLine("Exception at: " + ex.StackTrace);
                return null;
            }

        }
    }
}
