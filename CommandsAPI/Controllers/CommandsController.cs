using AutoMapper;
using CommandsAPI.Data;
using CommandsAPI.DTOs;
using CommandsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandRepo _repository;
        private readonly IMapper _mapper;

        public CommandsController(ICommandRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CommandsReadDto>> GetAll()
        {
            var commandsFromRepo = _repository.GetAllCommands();

            return Ok(_mapper.Map<IEnumerable<CommandsReadDto>>(commandsFromRepo));
        }

        [HttpGet("{id}", Name = "GetCommandById")]
        public ActionResult<CommandsReadDto> GetCommandById(int id)
        {
            var commandFromRepo = _repository.GetCommandById(id);
            if (commandFromRepo == null) return NotFound();

            return Ok(_mapper.Map<CommandsReadDto>(commandFromRepo));
        }

        [HttpPost]
        public ActionResult<CommandsReadDto> CreateCommand
            (CommandsCreateDto commandsCreateDto)
        {
            //var commandModel = _repository.CreateCommand(commandsCreateDto);
            var commandModel = _mapper.Map<Command>(commandsCreateDto);
            _repository.CreateCommand(commandModel);
            _repository.SaveChanges();

            var commandReadDto = _mapper.Map<CommandsReadDto>(commandModel);

            return CreatedAtRoute(nameof(GetCommandById), new
            {
                Id = commandReadDto.Id
            }, commandReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateCommand(int id,
            CommandsUpdateDto commandsUpdateDto)
        {
            var commandFromRepo = _repository.GetCommandById(id);
            if (commandFromRepo == null) return NotFound();

            _mapper.Map(commandsUpdateDto, commandFromRepo);
            _repository.UpdateCommand(commandFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCommand(int id)
        {
            var commandFromRepo = _repository.GetCommandById(id);
            if (commandFromRepo == null) return NotFound();

            _repository.DeleteCommand(commandFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

    }
}
