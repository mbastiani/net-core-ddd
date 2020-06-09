using CSharp.DDD.Domain.Interfaces.Repositories;
using CSharp.DDD.Domain.Interfaces.Services;
using CSharp.DDD.Domain.Models;

namespace CSharp.DDD.Core.Services
{
    public class ProductService : BaseService<Product>, IProductService
    {
        //private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
            : base(productRepository)
        {
            //_productRepository = productRepository;
        }
    }
}