using FreshShop.Business.Abstract;
using FreshShop.Business.Concrete;
using FreshShop.DataAccess.Abstract;
using FreshShop.DataAccess.Concrete;
using FreshShop.Model.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FreshShop.MvcWebUI
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
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddSingleton<ICategoryBs, CategoryBs>();
            services.AddSingleton<IRepository<Category>, CategoryRepository>();
            services.AddSingleton<IManagerBs, ManagerBs>();
            services.AddSingleton<IManagerRepository, ManagerRepository>();
            services.AddSingleton<IProductBs, ProductBs>();
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IProductPhotoBs, ProductPhotoBs>();
            services.AddSingleton<IProductPhotoRepository, ProductPhotoRepository>();
            services.AddSingleton<ICategoryBs, CategoryBs>();
            services.AddSingleton<ICategoryRepository, CategoryRepository>();

            //Session kullanmak i�in bunu .Net'e bildirmemiz gerekir.
            services.AddSession();


            //AddSingleton : O concrete s�n�ftan bir tane nesne yarat�r ve istenilen her yere o tek nesneyi yollar.
            //AddTransient : Her istenilen yerde o s�n�ftan bir nesne daha yarat�r ve yollar.
            //AddScoped : �stenilen yer i�in bir nesne yarat�r ve yollar o yerdeki birden fazla fonksiyona bu nesne gider
            //ancak ba�ka bir yerden daha istenildi�inde bu sefer yeniden nesnesini yarat�r ve bir tane de oraya yollar.
            //�rne�in bir controller i�inde birden fazka fonksiyona tek nesne yollar ama ba�ka controller i�in ba�ka nesne yarat�r.
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
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            //Session'u kullanmak i�in yazd�k.
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Manager}/{action=LogIn}/{id?}"
                );

                            
                endpoints.MapControllerRoute(
            name: "default",
            pattern: "{controller}/{action}/{id?}",
            defaults: new { controller = "Home", action = "Index" });


            });
        }
    }
}
