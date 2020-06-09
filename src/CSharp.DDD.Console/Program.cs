using CSharp.DDD.Domain.Interfaces.Data;
using CSharp.DDD.Domain.Models;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CSharp.DDD.Console
{
    internal static class Program
    {
        private static void Main()
        {
            IServiceCollection services = new ServiceCollection();
            Startup startup = new Startup();
            startup.ConfigureServices(services);
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            var personRepository = serviceProvider.GetService<IPersonRepository>();
            var productRepository = serviceProvider.GetService<IProductRepository>();

            var person = new Person
            {
                Name = "Person Name",
                Email = "Person E-mail"
            };

            personRepository.Add(person);

            var product = new Product
            {
                Name = "Product Name",
                Value = 10.50m,
                Person = person
            };

            productRepository.Add(product);
        }
    }
}