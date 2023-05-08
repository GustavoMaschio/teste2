using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using _50Blessings.Data;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace _50Blessings
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<_50BlessingsContext>(options =>
                options.UseMySql(Configuration.GetConnectionString("Server=localhost;Port=3306;Database=testeapi;Uid=root;Pwd="),
                    mySqlOptions =>
                    {
                        mySqlOptions.ServerVersion(new Version(8, 0, 21), ServerType.MySql); //versão do seu MySQL
                    }));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
