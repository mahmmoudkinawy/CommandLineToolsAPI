using AutoMapper;
using CommandsAPI.DTOs;
using CommandsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandsAPI.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandsReadDto>();
            CreateMap<CommandsCreateDto, Command>();
            CreateMap<CommandsUpdateDto, Command>();
        }
    }
}
