namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppComands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Open a can", Line = "Buy a can", Platform = "Cans" },
                new Command { Id = 1, HowTo = "Open a car", Line = "Buy a car", Platform = "Cars" },
                new Command { Id = 2, HowTo = "Shoot from a weapon", Line = "Buy a weapon", Platform = "Weapons" },
                new Command { Id = 3, HowTo = "Commit a change", Line = "Creaate git repo", Platform = "Git" }
            };
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = id, HowTo = "Open a can", Line = "Buy a can", Platform = "Cans" };
        }
    }
}