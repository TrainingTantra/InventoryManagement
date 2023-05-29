using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using System.Net.Http;
using Microsoft.Extensions.Http;
namespace Services
{
    public static class ServicesRegistrations
    {
        public static IServiceCollection AddRequiredServices(this IServiceCollection services, IConfiguration configuration)
        {
            // AutoMapper.Profiles
            // only once per-assembly is required as the entire assembly is scanned
            services.AddAutoMapper(typeof(ServicesRegistrations).Assembly);

            // services
            services.AddTransient<IPingService, PingService>();

            // http connections
            // see all interfaces in the assembly that implement INamedUriConfig
            services.AddHttpClient();
            return services;
        }
    }
}
