namespace CommandAPI.Tests
{
    using CommandAPI.Models;
    using System;
    using Xunit;
    public class CommandTests : IDisposable
    {
        private Command testCommand;

        public CommandTests()
        {
            testCommand = new Command
            {
                HowTo = "Do something awesome",
                Platform = "xUnit",
                CommandLine = "dotnet test"
            };
        }

        public void Dispose()
        {
            testCommand = null;
        }
      
        [Fact]
        public void CanChangeHowTo()
        {
            // Arrange

            // Act
            testCommand.HowTo = "Execute Unit Tests";

            // Assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePaltform()
        {
            testCommand.Platform = "MyTestedAspNet";
            Assert.Equal("MyTestedAspNet", testCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            testCommand.CommandLine = "New Cmd";
            Assert.Equal("New Cmd", testCommand.CommandLine);
        }
    }
}
