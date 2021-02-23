using CommandsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandsAPI.Data
{
    public class CommandsDbContext : DbContext
    {
        public CommandsDbContext(DbContextOptions<CommandsDbContext> options) : base(options)
        {

        }

        public DbSet<Command> GetCommands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Command>().HasData(
                new Command()
                {
                    Id = 1,
                    HowTo = "Make a dircetory",
                    CommandLine = "midir FILENAME",
                    Plateform = "All Operating Systems"
                },
                new Command()
                {
                    Id = 2,
                    HowTo = "Remove a dircetory",
                    CommandLine = "rmdir FILENAME",
                    Plateform = "All Operating Systems"
                },
                new Command()
                {
                    Id = 3,
                    HowTo = "Print something in Console",
                    CommandLine = "echo SOMETHINGTOPRINTE",
                    Plateform = "All Operating Systems"
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
