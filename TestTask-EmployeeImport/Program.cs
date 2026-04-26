using Microsoft.EntityFrameworkCore;
using TestTask_EmployeeImport.Models;
using TestTask_EmployeeImport.Services;

namespace TestTask_EmployeeImport
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

			builder.Services.AddDbContext<AppDbContext>(options =>
	        options.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=Employee_Data_Import_DB;Trusted_Connection=True;TrustServerCertificate=True"));

			builder.Services.AddScoped<DataImportService>();

			var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
