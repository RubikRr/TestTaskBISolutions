using Microsoft.EntityFrameworkCore;
using TestTaskBISolutions.Data;
using TestTaskBISolutions.Interfaces;
using TestTaskBISolutions.Storages;

namespace TestTaskBISolutions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            string connection = builder.Configuration.GetConnectionString("ToDo");
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(connection));
            builder.Services.AddTransient<IToDoListStorage,ToDoListStorage>();
            var app = builder.Build();

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

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=ToDoList}/{action=Index}/{id?}");

            app.Run();
        }
    }
}