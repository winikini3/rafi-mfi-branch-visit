using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rafi_mfi_branch_visit_api.Configurations;
using rafi_mfi_branch_visit_api.Data;
using rafi_mfi_branch_visit_api.Helpers;
using rafi_mfi_branch_visit_api.Interfaces;



namespace rafi_mfi_branch_visit_api.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddApiVersioning(setup =>
            {
                setup.DefaultApiVersion = new ApiVersion(1, 0);
                setup.AssumeDefaultVersionWhenUnspecified = true;
                setup.ReportApiVersions = true;
            });

            services.AddVersionedApiExplorer(setup =>
           {
               setup.GroupNameFormat = "'v'VVV";
               setup.SubstituteApiVersionInUrl = true;
           });


            services.AddSwaggerGen(c =>
            {
                c.EnableAnnotations();
            });

            services.ConfigureOptions<ConfigureSwaggerOptions>();
        }

        public static void ConfigureAutomapper(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        public static void ConfigureDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<IWeatherHelper, WeatherHelper>();
        }

        public static void ConfigureDBContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(database => database.UseSqlServer(configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient, ServiceLifetime.Singleton);
        }

        public static void ConfigureCORS(this IServiceCollection services, IConfiguration configuration, string allowedOrigin)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(allowedOrigin, policy => policy.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod());
            });
        }

    }
}