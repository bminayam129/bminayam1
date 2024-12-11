using Microsoft.EntityFrameworkCore;
using ShopItlaApp.Data.DAOS;
using ShopItlaApp.Data.Interfaces;

namespace ShopItlaApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<Data.Context.ShopContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DBShop")));
            builder.Services.AddScoped<IDaoCategories, DaoCategories>();
            builder.Services.AddControllersWithViews();
          
            var app = builder.Build(); 

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
