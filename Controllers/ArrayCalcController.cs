using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using calculator.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace calculator.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ArrayCalcController : ControllerBase
    {
        private readonly IProductService _productService;
        public ArrayCalcController(IProductService productService)
        {
            _productService = productService;
        }

        // GET api/arraycalc/reverse
        [HttpGet]
        public ActionResult<int[]> Reverse(int productId1, int productId2, int productId3, int productId4, int productId5 )
        {
            int[] response = new int[] { };
            int[] requestProductId = new int[] { productId1 , productId2, productId3, productId4, productId5};
            response = _productService.Reverse(requestProductId);

            return response;
        }

        // GET api/arraycalc/deletepart
        [HttpGet]
        public ActionResult<int[]> DeletePart(int position, int productId1, int productId2, int productId3, int productId4, int productId5)
        {
            int[] response = new int[] { };
            int[] requestProductId = new int[] { productId1, productId2, productId3, productId4, productId5 };

            if ((position > 0) && (position < requestProductId.Length))
            {                
                response = _productService.DeletePart(position, requestProductId);
            }

            return response;
        }
    }
}
