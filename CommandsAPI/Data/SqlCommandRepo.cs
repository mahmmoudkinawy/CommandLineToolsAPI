using CommandsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandsAPI.Data
{
    public class SqlCommandRepo : ICommandRepo
    {
        private readonly CommandsDbContext _context;

        public SqlCommandRepo(CommandsDbContext context)
        {
            _context = context;
        }
        public void CreateCommand(Command cmd)
        {
            _context.Add(cmd);
        }

        public void DeleteCommand(Command cmd)
        {
            _context.GetCommands.Remove(cmd);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.GetCommands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.GetCommands.FirstOrDefault(kh => kh.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateCommand(Command cmd)
        {
            //No Code Here
        }
    }
}
