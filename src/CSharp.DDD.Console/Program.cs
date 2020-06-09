using CSharp.DDD.Domain.Interfaces.Services;
using CSharp.DDD.Domain.Models;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CSharp.DDD.Console
{
    internal static class Program
    {
        private static void Main()
        {
            System.Console.WriteLine($"Start - {DateTime.Now}");

            IServiceCollection services = new ServiceCollection();
            Startup startup = new Startup();
            startup.ConfigureServices(services);
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            var personService = serviceProvider.GetService<IPersonService>();
            var productService = serviceProvider.GetService<IProductService>();

            var person = new Person
            {
                Name = "Person Name",
                Email = "Person E-mail"
            };

            personService.Add(person);

            var product = new Product
            {
                Name = "Product Name",
                Value = 10.50m,
                Person = person
            };

            productService.Add(product);

            System.Console.WriteLine($"Stop - {DateTime.Now}");
            System.Console.ReadKey();
        }
    }
}