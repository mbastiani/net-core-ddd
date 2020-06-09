using CSharp.DDD.Domain.Interfaces.Repositories;
using CSharp.DDD.Domain.Interfaces.Services;
using CSharp.DDD.Domain.Models;

namespace CSharp.DDD.Core.Services
{
    public class PersonService : BaseService<Person>, IPersonService
    {
        //private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
            : base(personRepository)
        {
            //_personRepository = personRepository;
        }
    }
}
