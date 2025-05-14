using Microsoft.Identity.Client;
using Witherborn.Controllers;
using Witherborn.Core.Controllers;
using Witherborn.Core.Services.Interfaces;
using Witherborn.Data;

namespace Witherborn.Views
{
    public class Menu(
        WitherbornDbContext context,
        IClassService classService,
        IItemService itemService,
        IQueryService queryService)
    {
        private readonly SeedDatabaseController seedDatabaseController = new SeedDatabaseController(context);
        private readonly ClassController classController = new ClassController(classService);
        private readonly ItemController itemController = new ItemController(itemService);
        private readonly QueryController queryController = new QueryController(queryService);

        public async Task UserInput()
        {
            #region Commands

            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ Welocme to Witherborn where you can expreince the Hypixel SkyBlock dungeon experience by using these commands:                 ║");
            Console.WriteLine("║ 1  SeedCommand -> {SeedClasses/SeedDungeons/SeedEnemies/SeedFloors/SeedItems/SeedPlayers/SeedPlayersDungeons/SeedPlayersItems} ║");
            Console.WriteLine("║ 2  EntityOption -> {Class/Item} OperationCommand -> {Add/Edit/Delete} UserInput -> {Depends on action and chosen entity}       ║");
            Console.WriteLine("║ 3  List all players by class name -> {Tank/Mage/Archer/Berserker/Healer}                                                       ║");
            Console.WriteLine("║ 4  List all players items by their username -> {Player username}                                                               ║");
            Console.WriteLine("║ 5  List all floors strongest enemy                                                                                             ║");
            Console.WriteLine("║ 6  List the player's stats                                                                                                     ║");
            Console.WriteLine("║ 7  List the player counts in each dungeon                                                                                      ║");
            Console.WriteLine("║ 8  Lists the top {User input} players with the most unique items                                                               ║");
            Console.WriteLine("║ 9  List all players by dungeon name -> {Undead Catacombs/Void Realm/Gemstone Caves/Arachnid Tunnels/Final Trial}               ║");
            Console.WriteLine("║ 10 Lists the player's overall stats <Total runs and total owned items count>                                                   ║");
            Console.WriteLine("║ 11 List the players above the minimum Catacombs level -> {Catacombs level}                                                     ║");
            Console.WriteLine("║ 12 Lists the players with the most items owned by a given item name -> {Terminator/Goldor's Armor/Hyperion/Bonzo Staff/etc.}   ║");
            Console.WriteLine("║ 0 Exits the Witherborn                                                                                                         ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");

            #endregion

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "0")
            {
                string command = input[0];

                if (command == "1")
                {
                    string seedCommand = input[1];
                    Console.WriteLine(await seedDatabaseController.Seed(seedCommand));
                }
                else if (command == "2")
                {
                    string entityType = input[1];
                    string operation = input[2];

                    if (entityType == "Class")
                    {
                        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
                        Console.WriteLine("║ Enter UserCommand -> {Add[Type, Description]/Edit[Id, Type]/Delete[Id]} ║");
                        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");

                        string crudCommand = Console.ReadLine() ?? string.Empty;
                        string[] userInput = crudCommand.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                        Console.WriteLine(await classController.ClassOperations(operation, userInput));
                    }
                    else if (entityType == "Item")
                    {
                        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════╗");
                        Console.WriteLine("║ Enter UserCommand -> {Add[Name|ItemType|Power]/Edit[Id|Name]/Delete[Id]}    ║");
                        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");

                        string crudCommand = Console.ReadLine() ?? string.Empty;
                        string[] userInput = crudCommand.Split('|', StringSplitOptions.RemoveEmptyEntries);

                        Console.WriteLine(await itemController.ItemOperations(operation, userInput));
                    }
                }
                else if(command == "3")
                {
                    string className = input[1];

                    Console.WriteLine(await queryController.GetPlayersByClassName(className));
                }
                else if (command == "4")
                {
                    string username = input[1];

                    Console.WriteLine(await queryController.GetPlayersItemsByPlayerUsername(username));
                }
                else if (command == "5")
                {
                    Console.WriteLine(await queryController.GetFloorsStrongestEnemy());
                }
                else if (command == "6")
                {
                    Console.WriteLine(await queryController.GetPlayersFullStats());
                }
                else if (command == "7")
                {
                    Console.WriteLine(await queryController.GetDungeonPlayerCounts());
                }
                else if (command == "8")
                {
                    int topCount = int.Parse(input[1]);

                    Console.WriteLine(await queryController.GetTopPlayersByUniqueItems(topCount));
                }
                else if (command == "9")
                {
                    string dungeonName = string.Join(" ", input.Skip(1));

                    Console.WriteLine(await queryController.GetPlayersByDungeonName(dungeonName));
                }
                else if (command == "10")
                {
                    Console.WriteLine(await queryController.GetPlayerOverallStats());
                }
                else if (command == "11")
                {
                    int cataLevel = int.Parse(input[1]);

                    Console.WriteLine(await queryController.GetPlayersByMinCatacombsLevel(cataLevel));
                }
                else if (command == "12")
                {
                    string itemName = string.Join(" ", input.Skip(1));

                    Console.WriteLine(await queryController.GetPlayersByOwnedItem(itemName));
                }

                #region Commands

                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ To continue with your experience use these commands:                                                                           ║");
                Console.WriteLine("║ 1  SeedCommand -> {SeedClasses/SeedDungeons/SeedEnemies/SeedFloors/SeedItems/SeedPlayers/SeedPlayersDungeons/SeedPlayersItems} ║");
                Console.WriteLine("║ 2  EntityOption -> {Class/Item} OperationCommand -> {Add/Edit/Delete} UserInput -> {Depends on action and chosen entity}       ║");
                Console.WriteLine("║ 3  List all players by class name -> {Tank/Mage/Archer/Berserker/Healer}                                                       ║");
                Console.WriteLine("║ 4  List all players items by their username -> {Player username}                                                               ║");
                Console.WriteLine("║ 5  List all floors strongest enemy                                                                                             ║");
                Console.WriteLine("║ 6  List the player's stats                                                                                                     ║");
                Console.WriteLine("║ 7  List the player counts in each dungeon                                                                                      ║");
                Console.WriteLine("║ 8  Lists the top {User input} players with the most unique items                                                               ║");
                Console.WriteLine("║ 9  List all players by dungeon name -> {Undead Catacombs/Void Realm/Gemstone Caves/Arachnid Tunnels/Final Trial}               ║");
                Console.WriteLine("║ 10 Lists the player's overall stats <Total runs and total owned items count>                                                   ║");
                Console.WriteLine("║ 11 List the players above the minimum Catacombs level -> {Catacombs level}                                                     ║");
                Console.WriteLine("║ 12 Lists the players with the most items owned by a given item name -> {Terminator/Goldor's Armor/Hyperion/Bonzo Staff/etc.}   ║");
                Console.WriteLine("║ 0 Exits the Witherborn                                                                                                         ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");

                #endregion

                input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }

    }
}
