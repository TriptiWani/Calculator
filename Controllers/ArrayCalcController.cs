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

        // GET api/arraycalc
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //// GET api/arraycalc
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Reverse()
        //{
        //    return new string[] { "Rvalue1", "Rvalue2" };
        //}

        // GET api/arraycalc/reverse
        [HttpGet]
        public ActionResult<int[]> Reverse()
        {
            int[] productId = new int[] { 1, 2, 3, 4, 5 };
            var reversedProduct = _productService.Reverse(productId);
            return reversedProduct;
        }

        [HttpGet]
        public ActionResult<int[]> DeletePart(int position)
        {
            int[] productId=  new int[] { 1, 2, 3, 4, 5 };
            var deletededProduct = _productService.DeletePart(position, productId);
            return deletededProduct;
        }
    }
}
