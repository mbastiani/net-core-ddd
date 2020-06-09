using CSharp.DDD.Data.Context;
using CSharp.DDD.Domain.Interfaces.Data;
using CSharp.DDD.Domain.Models;

namespace CSharp.DDD.Data.Repositories
{
    public class ProductRepository: BaseRepository<Product>, IProductRepository
    {
        //private readonly AppDbContext _context;
        public ProductRepository(AppDbContext Context)
            : base(Context)
        {
           // _context = Context;
        }
    }
}