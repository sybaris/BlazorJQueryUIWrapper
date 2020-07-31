using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorJQueryUIWrapper.Library.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBlazorJQueryUI(this IServiceCollection services)
        {
            // Commented because not a new component...
            //services.AddScoped<BlazorJQueryUIWrapperDOM>();
            return services;
        }
    }
}
