using Api.Domain;
using FoodApp.Data;
using FoodApp.Repositories;
using FoodApp.Services;
using FoodApp.Services.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Api.Infrastructure
{
    public class DependenciesConfiguration
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            //services.AddLocalization(o => o.ResourcesPath = "Resources");

            services.AddDbContext<DataContext>(options => options
                .UseMySql(configuration["DataBaseConnectionString"], new MySqlServerVersion(new Version(5, 7, 12)))
                .ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.DetachedLazyLoadingWarning, RelationalEventId.BoolWithDefaultWarning))
                //.UseLazyLoadingProxies()
            );

            ConfigureDomainNotifications(services);


            // Services
            services.AddScoped<IFoodCrudService, FoodCrudService>();


            // Repositories
            services.AddScoped<FoodRepository>();


            // Queues, Dequeues, etc.
            //services.AddSingleton<>();

            // Background Workers & Processors
            //services.AddScoped<ScheduleDoneProcessorService>();

            //if (configuration.GetValue<bool>("IsEnabled:BackgroundServices"))
            //{ 
            //    //services.AddHostedService<>()
            //}
        }

        private static void ConfigureDomainNotifications(IServiceCollection services)
        {
            services.AddScoped<INotificationContext, NotificationContext>();
            //services.AddMvc(options => options.Filters.Add<DomainNotificationFilter>());
        }
    }
}
