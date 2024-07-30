﻿using Microsoft.EntityFrameworkCore;

namespace Services.Auth.GoogleAuth.Api.Data
{
    public class Seeder
    {
        public static async Task Seed(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var logger = scope.ServiceProvider.GetRequiredService<ILogger<Seeder>>();
                try
                {

                    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                    await context.Database.MigrateAsync();

                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
    }
}
