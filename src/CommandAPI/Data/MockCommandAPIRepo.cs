namespace CommandAPI.Data
{
    using System.Collections.Generic;
    using CommandAPI.Models;

    public class MockCommandAPIRepo : ICommandAPIRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>();

            commands.Add(new Command
            {
                Id = 0,
                HowTo = "How to generete migration",
                CommandLine = "dotnet ef migrations add <Name of Migration>",
                Platform = ".Net Core Ef"
            });

            commands.Add(new Command
            {
                Id = 1,
                HowTo = "Run Migrations",
                CommandLine = "dotnet ef database update",
                Platform = ".Net Core Ef"
            });

            commands.Add(new Command
            {
                Id = 2,
                HowTo = "List active migrations",
                CommandLine = "dotnet ef migrations list",
                Platform = ".Net Core Ef"
            });
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command
            {
                Id = 0,
                HowTo = "How to generate a migration",
                CommandLine = "dotnet ef migrations add <Name of Migration>",
                Platform=".Net Core EF"
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}