namespace CommandAPISolution.Seeder
{
    using CommandAPISolution.Data;
    using System;
    using System.IO;
    using System.Linq;
    using Newtonsoft.Json;
    using CommandAPI.Models;

    public class CommandSeeder : ISeeder
    {
        public void Seed(CommandContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.CommandItems.Any())
            {
                return;
            }

            var file = new StreamReader("dataSeed.json");
            var jsonStr = file.ReadToEnd();

            dynamic dynJson = JsonConvert.DeserializeObject(jsonStr);

            foreach (var item in dynJson)
            {
                var cmd = new Command()
                {
                    HowTo = item.howTo,
                    CommandLine = item.commandLine,
                    Platform = item.platform
                };

                dbContext.Add(cmd);
            }

            dbContext.SaveChanges();
        }
    }
}
