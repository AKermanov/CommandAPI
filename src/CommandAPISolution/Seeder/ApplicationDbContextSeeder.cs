using CommandAPISolution.Data;
using System;
using System.Collections.Generic;

namespace CommandAPISolution.Seeder
{
    public class ApplicationDbContextSeeder
    {
        public void Seed(CommandContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext is null)
            {
                throw new ArgumentNullException(nameof(dbContext));
            }
            if (serviceProvider is null)
            {
                throw new ArgumentNullException(nameof(serviceProvider));
            }
            var seeders = new List<ISeeder>
            {
                new CommandSeeder(),
             };

            foreach (var seeder in seeders)
            {
                seeder.Seed(dbContext, serviceProvider);
                dbContext.SaveChanges();

            }
        }
    }
}
