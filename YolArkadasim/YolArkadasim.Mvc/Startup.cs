using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using YolArkadasim.Mvc.AutoMapper.Profiles;
using YolArkadasim.Mvc.Helpers.Abstract;
using YolArkadasim.Mvc.Helpers.Concrete;
using YolArkadasim.Services.AutoMapper.Profiles;
using YolArkadasim.Services.Extensions;


namespace YolArkadasim.Mvc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddRazorRuntimeCompilation().AddJsonOptions(opt =>
            {
                opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
            });
            //sen mvc uygulamasısın.
            //Razor sayesinde front-end'de derlemeden de işlem yapabileceğiz.
            //Json Seirelizer : front-end tarafına dönülen modelin js tarafında da anlaşılabilmesini sağlar.

            services.AddSession();
            services.AddAutoMapper(typeof(CategoryProfile),typeof(JourneyProfile),typeof(UserProfile),typeof(ViewModelsProfile)); //derlenme esnasında AutoMapper'in sınıfları taramasını sağlar.
            services.LoadMyServices(connectionString:Configuration.GetConnectionString("LocalDB")); //dataları almayı sağlar.
            services.AddScoped<IImageHelper, ImageHelper>();
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = new PathString("/Admin/User/Login");
                options.LogoutPath = new PathString("/Admin/User/Logout");
                options.Cookie = new CookieBuilder
                {
                    Name = "YolArkadasim",
                    HttpOnly = true,
                    SameSite = SameSiteMode.Strict,
                    SecurePolicy = CookieSecurePolicy.SameAsRequest // Always
                };
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = System.TimeSpan.FromDays(7);//7 gün girişi kayıtlı kalacak
                options.AccessDeniedPath = new PathString("/Admin/User/AccessDenied");//yetkisiz yere giriş yaparken
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages(); //404 not found verir.
            }

            app.UseSession();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "Admin",
                    areaName: "Admin",
                    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
                );
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
