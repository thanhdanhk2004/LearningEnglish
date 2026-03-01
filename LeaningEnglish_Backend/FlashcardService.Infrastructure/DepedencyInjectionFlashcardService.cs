using FlashcardService.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashcardService.Infrastructure
{
    public static class DepedencyInjectionFlashcardService
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DBContextFlashcard>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("ConnectDB"))
                .ConfigureWarnings(warnings =>
                           warnings.Ignore(RelationalEventId.AllIndexPropertiesNotToMappedToAnyTable));
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });
            return services;
        }
    }
}
