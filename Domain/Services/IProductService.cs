using System.Collections.Generic;
using System.Threading.Tasks;
using calculator.Domain.Models;

namespace calculator.Domain.Services
{
    public interface IProductService
    {
        int[] Reverse(int[] productId);
        int[] DeletePart(int position, int[] productId);
    }
}