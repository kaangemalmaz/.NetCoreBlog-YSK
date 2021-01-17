using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Authentication;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using YSKProje.WEB.ApiServices.Concrete;
using YSKProje.WEB.ApiServices.Interfaces;

namespace YSKProje.WEB
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
           
            services.AddHttpContextAccessor();
            services.AddSession();
            //services.AddHttpClient<IBlogApiService, BlogApiManager>();
            //services.AddHttpClient<ICategoryApiService, CategoryApiManager>();
            services.AddHttpClient<IBlogApiService, BlogApiManager>();
            services.AddHttpClient<ICategoryApiService, CategoryApiManager>();
            services.AddHttpClient<IImageApiService, ImageApiManager>();
            services.AddHttpClient<IAuthApiService, AuthApiManager>();
            //services.AddHttpClient<IBlogApiService, BlogApiManager>().ConfigurePrimaryHttpMessageHandler(() =>
            // {
            //     var handler = new HttpClientHandler();
            //     handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            //     handler.SslProtocols = SslProtocols.Tls12 | SslProtocols.Tls11 | SslProtocols.Tls;
            //     return handler;

            // });

            //services.AddHttpClient<ICategoryApiService, CategoryApiManager>().ConfigurePrimaryHttpMessageHandler(() =>
            // {
            //     var handler = new HttpClientHandler();
            //     handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            //     handler.SslProtocols = SslProtocols.Tls12 | SslProtocols.Tls11 | SslProtocols.Tls;
            //     return handler;

            // });

            //services.AddHttpClient<IImageApiService, ImageApiManager>().ConfigurePrimaryHttpMessageHandler(() =>
            //{
            //    var handler = new HttpClientHandler();
            //    handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            //    handler.SslProtocols = SslProtocols.Tls12 | SslProtocols.Tls11 | SslProtocols.Tls;
            //    return handler;

            //});

            //services.AddHttpClient<IAuthApiService, AuthApiManager>().ConfigurePrimaryHttpMessageHandler(() =>
            //{
            //    var handler = new HttpClientHandler();
            //    handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            //    handler.SslProtocols = SslProtocols.Tls12 | SslProtocols.Tls11 | SslProtocols.Tls;
            //    return handler;

            //});

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHsts();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapDefaultControllerRoute();
                endpoints.MapControllerRoute(
                name: "areas",
                pattern: "{area}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
