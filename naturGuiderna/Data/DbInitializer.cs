using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace naturGuiderna.Data
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<NatureDbContext>();

                // Check that database exist
                context.Database.EnsureCreated();

                // Location
                // Experience
                // Guide
                // Category
                // NatureActivity
                // Experince & NatureActivity
                //
            }
        }
    }
}
