using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Blog.Service.Services.Abstractions;
using Blog.Service.Services.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Service.Extentions
{
    public static class ServiceLayerExtentions
    {
        public static IServiceCollection LoadServiceLayerExtention(this IServiceCollection services,
            IConfiguration config)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddScoped<IArticleService, ArticleService>();

            services.AddAutoMapper(assembly);
            
            

            return services;
        }
    }
}
