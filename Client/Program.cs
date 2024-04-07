using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Client.Data;
namespace Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<ClientContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("ClientContext") ?? throw new InvalidOperationException("Connection string 'ClientContext' not found.")));

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddScoped<IClienteService, ClienteService>();
            builder.Services.AddHttpClient();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Clientes}/{action=Index}/{id?}");
            });

            app.Run();
        }
    }
}
