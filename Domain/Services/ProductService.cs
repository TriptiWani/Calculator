using calculator.Domain.Services;
using calculator.Repositories;
using System;
using System.Collections.Generic;

namespace calculator.API.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public int[] Reverse(int[] productId)
        {
            return _productRepository.Reverse(productId);
        }

        public int[] DeletePart(int position, int[] productId)
        {
            return _productRepository.DeletePart(position, productId);
        }
    }
}