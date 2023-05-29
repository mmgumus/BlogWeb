using Blog.Data.Repositories.Abstractions;
using Blog.Data.Repositories.Concretes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Data.Extentions;

    public static class DataLayerExtentions
    {
        public static IServiceCollection LoadDataLayerExtentions(this IServiceCollection services,
            IConfiguration config)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>)); 
            return services;
        }
    }
