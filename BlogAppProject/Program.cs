using BlogAppProject.Data.Abstract;
using BlogAppProject.Data.Concrete.EfCore;
using BlogAppProject.Data.Concrete;
using BlogAppProject.Entities;

namespace BlogAppProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<BlogContext>();


            builder.Services.AddScoped<IPostRepository, EfPostRepository>();
            builder.Services.AddScoped<ITagRepository, EfTagRepositroy>();

            var app = builder.Build();

            SeedData.TestVerileriniDoldur(app);

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthorization();

            //localhost://blogs/react-dersleri

            app.MapControllerRoute(
               name: "post_details",
               pattern: "/posts/{url}",
               defaults: new {controller ="Post", action = "Details"}
               );

			app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.Run();


        }
    }
}
