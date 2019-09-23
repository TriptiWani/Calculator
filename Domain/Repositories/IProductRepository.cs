using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculator.Domain.Repositories
{
    public interface IProductRepository
    {
        int[] Reverse(int[] productId);
        int[] DeletePart(int position, int[] productId);
    }
}
