using AssignmentsWeb.Data;
using AssignmentsWeb.Persistence;
using AssignmentsWeb.Services;
using AssignmentsWeb.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;


namespace AssignmentsWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Connect context and connectionstring
            builder.Services.AddDbContext<AssignmentContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("MyDBConnection"));
            });
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            });

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Endpoint for breaking bad quotes
            builder.Services.AddHttpClient("BreakingBadClient", client =>
            {
                client.BaseAddress = new Uri("https://api.breakingbadquotes.xyz/v1/");
            });

            // Endpoint for pokemon API
            builder.Services.AddHttpClient("PokemonClient", client =>
            {
                client.BaseAddress = new Uri("https://pokeapi.co/api/v2/");
            });

            // Endpoint for Cat API
            builder.Services.AddHttpClient("CatClient", client =>
            {
                client.BaseAddress = new Uri("https://cataas.com/");
            });

            builder.Services.AddScoped<IHTTPService, HTTPService>();

            builder.Services.AddScoped<AssignmentRepository>();
            builder.Services.AddRazorPages();


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
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapRazorPages();

            app.Run();
        }
    }
}
