using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonData
{
    public static class DataRegistrations
    {
        public static IServiceCollection AddDataRegistrations(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IUsers,Users>();
            return services;
        }
    }
}
