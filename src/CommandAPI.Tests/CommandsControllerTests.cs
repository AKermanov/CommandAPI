namespace CommandAPI.Tests
{
    using AutoMapper;
    using CommandAPI.Controllers;
    using CommandAPI.Data;
    using CommandAPI.Models;
    using CommandAPISolution.Dtos;
    using CommandAPISolution.Profiles;
    using Microsoft.AspNetCore.Mvc;
    using Moq;
    using System;
    using System.Collections.Generic;
    using Xunit;
    public class CommandsControllerTests : IDisposable
    {
        private Mock<ICommandAPIRepo> mockRepo;
        private CommandsProfile realProfile;
        private MapperConfiguration configuration;
        private IMapper mapper;
        private CommandsController controller;

        public CommandsControllerTests()
        {
            mockRepo = new Mock<ICommandAPIRepo>();
            realProfile = new CommandsProfile();
            configuration = new MapperConfiguration(cfg => cfg.AddProfile(realProfile));
            mapper = new Mapper(configuration);
            controller = new CommandsController(mockRepo.Object, mapper);
        }
        public void Dispose()
        {
            mockRepo = null;
            mapper = null;
            configuration = null;
            realProfile = null;
        }

        [Fact]
        public void GetCommandItems_ReturnsZeroItems_WhenDBIsEmpty()
        {
            // Arrange
            mockRepo.Setup(repo => repo.GetAllCommands()).Returns(GetCommands(0));

            // Act
            var result = controller.GetAllCommands();

            // Assert
            Assert.IsType<OkObjectResult>(result.Result);
        }

        [Fact]
        public void GetAllCommands_ReturnsOneItem_WhenDBHasOneResource()
        {
            // Arrange
            mockRepo.Setup(repo => repo.GetAllCommands()).Returns(GetCommands(1));

            // Act
            var result = controller.GetAllCommands();

            // Assert
            var okResult = result.Result as OkObjectResult;
            var commands = okResult.Value as List<CommandReadDto>;
            Assert.Single(commands);
        }

        [Fact]
        public void GetAllCommands_Return200OK_WHenDBHasOneResource()
        {
            // Arrange
            mockRepo.Setup(repo => repo.GetAllCommands()).Returns(GetCommands(1));

            // Act
            var result = controller.GetAllCommands();

            // Assert
            Assert.IsType<OkObjectResult>(result.Result);
        }

        [Fact]
        public void GetAllCommands_ReturnsCorrectType_WhenHasOneResource()
        {
            // Arrange
            mockRepo.Setup(repo => repo.GetAllCommands()).Returns(GetCommands(1));

            // Act
            var result = controller.GetAllCommands();

            // Assert
            Assert.IsType<ActionResult<IEnumerable<CommandReadDto>>>(result);
        }
        private List<Command> GetCommands(int num)
        {
            var commands = new List<Command>();
            if (num > 0)
            {
                commands.Add(new Command
                {
                    Id = 0,
                    HowTo = "How to generate a migration",
                    CommandLine = "dotnet ef migrations add <Name of Migration>",
                    Platform = ".Net Core EF"
                });
            }
            return commands;
        }
    }
}
