
namespace CommandAPISolution.Data
{
    using CommandAPI.Models;
    using Microsoft.EntityFrameworkCore;
    public class CommandContext : DbContext
    {
        public CommandContext(DbContextOptions<CommandContext> options)
            : base(options)
        {

        }

        public DbSet<Command> CommandItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Command>().HasData(
                new Command()
                {
                    Id = 1,
                    HowTo = "How to generete migration",
                    CommandLine = "dotnet ef migrations add <Name of Migration>",
                    Platform = ".Net Core Ef"
                },
                new Command()
                {
                    Id = 2,
                    HowTo = "Run Migrations",
                    CommandLine = "dotnet ef database update",
                    Platform = ".Net Core Ef"
                },
                new Command()
                {
                    Id = 3,
                    HowTo = "List active migrations",
                    CommandLine = "dotnet ef migrations list",
                    Platform = ".Net Core Ef"
                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
