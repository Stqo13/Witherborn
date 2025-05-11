using Witherborn.Data;

namespace Witherborn.Core.Controllers
{
    public class SeedDatabaseController(WitherbornDbContext context)
    {
        public async Task<string> Seed(string command)
        {
            string result = string.Empty;

            if (command == "SeedClasses")
            {
                result = await SeedDatabaseService.SeedClasses(context);
            }
            else if(command == "SeedDungeons")
            {
                result = await SeedDatabaseService.SeedDungeons(context);
            }
            else if (command == "SeedEnemies")
            {
                result = await SeedDatabaseService.SeedEnemies(context);
            }
            else if (command == "SeedFloors")
            {
                result = await SeedDatabaseService.SeedFloors(context);
            }
            else if (command == "SeedItems")
            {
                result = await SeedDatabaseService.SeedItems(context);
            }
            else if (command == "SeedPlayers")
            {
                result = await SeedDatabaseService.SeedPlayers(context);
            }
            else if (command == "SeedPlayersDungeons")
            {
                result = await SeedDatabaseService.SeedPlayersDungeons(context);
            }
            else if (command == "SeedPlayersItems")
            {
                result = await SeedDatabaseService.SeedPlayersItems(context);
            }

            return result;
        }
    }
}
