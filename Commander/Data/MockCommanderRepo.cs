using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppComands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, BirthDate = "1953-09-02", FirstName = "Georgi", LastName = "Facello", Gender = "M", HireDate =  "1986-06-26" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, BirthDate = "1953-09-02", FirstName = "Georgi", LastName = "Facello", Gender = "M", HireDate = "1986-06-26" };
        }
    }
}