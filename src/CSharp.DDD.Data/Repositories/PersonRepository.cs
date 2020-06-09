using CSharp.DDD.Data.Context;
using CSharp.DDD.Domain.Interfaces.Repositories;
using CSharp.DDD.Domain.Models;

namespace CSharp.DDD.Data.Repositories
{
    public class PersonRepository: BaseRepository<Person>, IPersonRepository
    {
        //private readonly AppDbContext _context;
        public PersonRepository(AppDbContext Context)
            : base(Context)
        {
           // _context = Context;
        }
    }
}