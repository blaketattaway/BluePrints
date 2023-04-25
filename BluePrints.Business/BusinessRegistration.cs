using Microsoft.Extensions.DependencyInjection;
using BluePrints.Data;

namespace BluePrints.Business
{
    public static class BusinessRegistration
    {
        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            services.AddData();
            return services;
        }
    }
}