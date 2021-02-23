using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandsAPI.DTOs
{
    public class CommandsReadDto
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Plateform { get; set; }
        public string CommandLine { get; set; }
    }
}
