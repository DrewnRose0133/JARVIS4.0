using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JARVIS.Config
{
    public static class JarvisServiceExtensions
    {
        public static IServiceCollection AddJarvisServices(this IServiceCollection services, IConfiguration config)
        {
            return services;
        }
    }
}
