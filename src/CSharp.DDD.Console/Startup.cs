using CSharp.DDD.Data.Context;
using CSharp.DDD.Data.Repositories;
using CSharp.DDD.Domain.Interfaces.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CSharp.DDD.Console
{
    public class Startup
    {
        private readonly IConfigurationRoot _configuration;

        public Startup()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            _configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseMySQL(_configuration.GetConnectionString("MySql"))
            );
            //services.AddSingleton<AppDbContext>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddSingleton<IProductRepository, ProductRepository>();
        }
    }
}