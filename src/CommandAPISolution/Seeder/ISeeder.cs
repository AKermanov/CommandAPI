namespace CommandAPISolution.Seeder
{
    using CommandAPISolution.Data;
    using System;

    public interface ISeeder
    {
        void Seed (CommandContext dbContext, IServiceProvider serviceProvider);
    }
}
