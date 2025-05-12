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

            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ Welocme to Witherborn where you can expreince the Hypixel SkyBlock dungeon experience by using these commands:           ║");
            Console.WriteLine("║ 1  SeedCommand -> {SeedClasses/SeedDungeons/SeedEnemies/SeedFloors/SeedItems/SeedPlayers/SeedPlayersDungeons/SeedItems}  ║");
            Console.WriteLine("║ 2  EntityOption -> {Class/Item} OperationCommand -> {Add/Edit/Delete} UserInput -> {Depends on action and chosen entity} ║");
            Console.WriteLine("║ 3  List all players by class name -> {Tank/Mage/Archer/Berserker/Healer}                                                 ║");
            Console.WriteLine("║ 4  List all players items by their username -> {Player username}                                                         ║");
            Console.WriteLine("║ 5  List all floors strongest enemy                                                                                       ║");
            Console.WriteLine("║ 6                                                                                                                        ║");
            Console.WriteLine("║ 7                                                                                                                        ║");
            Console.WriteLine("║ 8                                                                                                                        ║");
            Console.WriteLine("║ 9                                                                                                                        ║");
            Console.WriteLine("║ 10                                                                                                                       ║");
            Console.WriteLine("║ 11                                                                                                                       ║");
            Console.WriteLine("║ 12                                                                                                                       ║");
            Console.WriteLine("║ 13                                                                                                                       ║");
            Console.WriteLine("║ 14                                                                                                                       ║");
            Console.WriteLine("║ 15                                                                                                                       ║");
            Console.WriteLine("║ End                                                                                                                      ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");

            #endregion

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "End")
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

                    string[] userInput = input[3].Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    if (entityType == "Class")
                    {
                        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
                        Console.WriteLine("║ Enter UserCommand -> {Add[Type, Description]/Edit[Id, Type]/Delete[Id]} ║");
                        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");

                        Console.WriteLine(await classController.ClassOperations(operation, userInput));
                    }
                    else if (entityType == "Item")
                    {
                        Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
                        Console.WriteLine("║ Enter UserCommand -> {Ad[Type, Description]/Edit[Id, Type]/Delete[Id]} ║");
                        Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");

                        Console.WriteLine(await itemController.ItemOperations(operation,userInput));
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

                }
                else if (command == "7")
                {

                }
                else if (command == "8")
                {

                }
                else if (command == "9")
                {

                }
                else if (command == "10")
                {

                }
                else if (command == "11")
                {

                }
                else if (command == "12")
                {

                }
                else if (command == "13")
                {

                }
                else if (command == "14")
                {

                }
                else if (command == "15")
                {

                }

                #region Commands

                Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ To continue with your experience use these commands:                                                                     ║");
                Console.WriteLine("║ 1  SeedCommand -> {SeedClasses/SeedDungeons/SeedEnemies/SeedFloors/SeedItems/SeedPlayers/SeedPlayersDungeons/SeedItems}  ║");
                Console.WriteLine("║ 2  EntityOption -> {Class/Item} OperationCommand -> {Add/Edit/Delete} UserInput -> {Depends on action and chosen entity} ║");
                Console.WriteLine("║ 3  List all players by class name -> {Tank/Mage/Archer/Berserker/Healer}                                                 ║");
                Console.WriteLine("║ 4  List all players items by their username -> {Player username}                                                         ║");
                Console.WriteLine("║ 5  List all floors strongest enemy                                                                                       ║");
                Console.WriteLine("║ 6                                                                                                                        ║");
                Console.WriteLine("║ 7                                                                                                                        ║");
                Console.WriteLine("║ 8                                                                                                                        ║");
                Console.WriteLine("║ 9                                                                                                                        ║");
                Console.WriteLine("║ 10                                                                                                                       ║");
                Console.WriteLine("║ 11                                                                                                                       ║");
                Console.WriteLine("║ 12                                                                                                                       ║");
                Console.WriteLine("║ 13                                                                                                                       ║");
                Console.WriteLine("║ 14                                                                                                                       ║");
                Console.WriteLine("║ 15                                                                                                                       ║");
                Console.WriteLine("║ End                                                                                                                      ║");
                Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");

                #endregion

                input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }

    }
}
