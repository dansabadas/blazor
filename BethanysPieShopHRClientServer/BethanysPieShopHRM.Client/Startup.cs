using System.Net.Http;
using BethanysPieShopHRM.Server;
using BethanysPieShopHRM.Server.Services;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BethanysPieShopHRM.ClientApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped(s => new HttpClient
            {
                BaseAddress = new System.Uri("https://bethanyspieshophrmapi20200107114511.azurewebsites.net/")
            }); //https://bethanyspieshophrmapi20200107114511.azurewebsites.net/ https://localhost:44340/

            //services.AddScoped<IEmployeeDataService, MockEmployeeDataService>();
            services.AddScoped<IEmployeeDataService, EmployeeDataService>();
            services.AddScoped<ICountryDataService, CountryDataService>();
            services.AddScoped<IJobCategoryDataService, JobCategoryDataService>();

            services
                .AddSignalR()
                .AddAzureSignalR("Endpoint=https://bethanyspieshophrmsignalrdanson.service.signalr.net;AccessKey=4YUlOwUSQRl7vBYsmda8bgGXpuAh");
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
