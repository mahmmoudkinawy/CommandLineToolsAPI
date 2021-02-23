using CommandsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandsAPI.Data
{
    public class CommandRepo : ICommandRepo
    {
        private readonly List<Command> commands;
        public CommandRepo()
        {
            commands = new List<Command>()
            {
                new Command()
                {
                    Id = 0 ,
                    HowTo = "Make a dircetory",
                    CommandLine ="midir FILENAME" ,
                    Plateform = "All Operating Systems"
                },
                new Command()
                {
                    Id = 1 ,
                    HowTo = "Remove a dircetory",
                    CommandLine ="rmdir FILENAME" ,
                    Plateform = "All Operating Systems"
                },
                new Command()
                {
                    Id = 3 ,
                    HowTo = "Print something in Console",
                    CommandLine ="echo SOMETHINGTOPRINTE" ,
                    Plateform = "All Operating Systems"
                }
            };
        }

        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return commands.FirstOrDefault(kh => kh.Id == id);
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
