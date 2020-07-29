using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BlazorJQueryUIWrapper.TestApp.CommonLib;
using BlazorJQueryUIWrapper.Library.Extensions;
using BlazorJQueryUIWrapper.TestApp.BlazorServer.Data;

namespace BlazorJQueryUIWrapper.TestApp.BlazorClient
{
    public class Program
    {
        // Note that we have some errors launching app : https://github.com/dotnet/aspnetcore/issues/20256
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddBaseAddressHttpClient();
            builder.Services.AddBlazorJQueryUI();
            
            builder.Services.AddSingleton<WeatherForecastService>();

            await builder.Build().RunAsync();
        }
    }
}
