using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommandsAPI.DTOs
{
    public class CommandsUpdateDto
    {
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        [MaxLength(250)]
        public string Plateform { get; set; }

        [Required]
        [MaxLength(500)]
        public string CommandLine { get; set; }
    }
}
