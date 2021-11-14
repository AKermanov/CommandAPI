namespace CommandAPI.Controllers
{
    using System.Collections.Generic;
    using CommandAPI.Data;
    using CommandAPI.Models;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandAPIRepo _repository;
        public CommandsController(ICommandAPIRepo repsitory)
        {
            _repository = repsitory;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }


        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            if (commandItem is null)
            {
                return NotFound();
            }

            return Ok(commandItem);
        }
    }
}