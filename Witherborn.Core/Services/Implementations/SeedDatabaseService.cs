using Microsoft.EntityFrameworkCore;
using Witherborn.Data;
using Witherborn.Data.Models;

public static class SeedDatabaseService
{
    public static async Task<string> SeedClasses(WitherbornDbContext context)
    {
        string path = @"../../../../Witherborn.Core/Services/Implementations/SeedInput/classes.txt";

        string[] classesInfo = await File.ReadAllLinesAsync(path);

        if (!await context.Classes.AnyAsync())
        {
            foreach (var item in classesInfo)
            {
                string[] info = item.Split('|', StringSplitOptions.RemoveEmptyEntries);

                var entity = new Class
                {
                    Type = info[0],
                    Description = info[1]
                };

                await context.AddAsync(entity);
                await context.SaveChangesAsync();
            }

            return "Successfully seeded the information!";
        }

        return "The table classes is already seeded!";
    }

    public static async Task<string> SeedDungeons(WitherbornDbContext context)
    {
        var path = @"../../../../Witherborn.Core/Services/Implementations/SeedInput/dungeons.txt";

        string[] dungeonsInfo = await File.ReadAllLinesAsync(path);

        if (!await context.Dungeons.AnyAsync())
        {
            foreach (var item in dungeonsInfo)
            {
                string[] info = item.Split('|', StringSplitOptions.RemoveEmptyEntries);

                var entity = new Dungeon
                {
                    Type = info[0],
                    DifficultyLevel = int.Parse(info[1]),
                    Name = info[2]
                };

                await context.AddAsync(entity);
                await context.SaveChangesAsync();
            }

            return "Successfully seeded the information!";
        }

        return "The table dungeons is already seeded!";
    }

    public static async Task<string> SeedEnemies(WitherbornDbContext context)
    {
        string path = @"../../../../Witherborn.Core/Services/Implementations/SeedInput/enemies.txt";

        string[] enemiesInfo = await File.ReadAllLinesAsync(path);

        if (!await context.Enemies.AnyAsync())
        {
            foreach (var item in enemiesInfo)
            {
                string[] info = item.Split('|', StringSplitOptions.RemoveEmptyEntries);

                var entity = new Enemy
                {
                    Name = info[0],
                    Strength = int.Parse(info[1]),
                    DungeonId = int.Parse(info[2]),
                };

                await context.AddAsync(entity);
                await context.SaveChangesAsync();
            }

            return "Successfully seeded the information!";
        }

        return "The table enemies is already seeded!";
    }

    public static async Task<string> SeedFloors(WitherbornDbContext context)
    {
        string path = @"../../../../Witherborn.Core/Services/Implementations/SeedInput/floors.txt";

        string[] floorsInfo = await File.ReadAllLinesAsync(path);

        if (!await context.Floors.AnyAsync())
        {
            foreach (var item in floorsInfo)
            {
                string[] info = item.Split('|', StringSplitOptions.RemoveEmptyEntries);

                var entity = new Floor
                {
                    FloorNumber = int.Parse(info[0]),
                    BossName = info[1],
                    DungeonId = int.Parse(info[2]),
                };

                await context.AddAsync(entity);
                await context.SaveChangesAsync();
            }

            return "Successfully seeded the information!";
        }

        return "The table floors is already seeded!";
    }

    public static async Task<string> SeedItems(WitherbornDbContext context)
    {
        string path = @"../../../../Witherborn.Core/Services/Implementations/SeedInput/items.txt";

        string[] itemsInfo = await File.ReadAllLinesAsync(path);

        if (!await context.Items.AnyAsync())
        {
            foreach (var item in itemsInfo)
            {
                string[] info = item.Split('|', StringSplitOptions.RemoveEmptyEntries);

                var entity = new Item
                {
                    Name = info[0],
                    ItemType = info[1],
                    Power = int.Parse(info[2])
                };

                await context.AddAsync(entity);
                await context.SaveChangesAsync();
            }

            return "Successfully seeded the information!";
        }

        return "The table items is already seeded!";
    }

    public static async Task<string> SeedPlayers(WitherbornDbContext context)
    {
        string path = @"../../../../Witherborn.Core/Services/Implementations/SeedInput/players.txt";

        string[] playersInfo = await File.ReadAllLinesAsync(path);

        if (!await context.Players.AnyAsync())
        {
            foreach (var item in playersInfo)
            {
                string[] info = item.Split('|', StringSplitOptions.RemoveEmptyEntries);

                var entity = new Player
                {
                    Username = info[0],
                    CatacombsLevel = int.Parse(info[1]),
                    RunCompletions = int.Parse(info[2]),
                    ClassId = int.Parse(info[3])
                };

                await context.AddAsync(entity);
                await context.SaveChangesAsync();
            }

            return "Successfully seeded the information!";
        }

        return "The table players is already seeded!";
    }

    public static async Task<string> SeedPlayersDungeons(WitherbornDbContext context)
    {
        string path = @"../../../../Witherborn.Core/Services/Implementations/SeedInput/players_dungeons.txt";

        string[] playersDungeonsInfo = await File.ReadAllLinesAsync(path);

        if (!await context.PlayersDungeons.AnyAsync())
        {
            foreach (var item in playersDungeonsInfo)
            {
                string[] info = item.Split('|', StringSplitOptions.RemoveEmptyEntries);

                var entity = new PlayerDungeon
                {
                    PlayerId = int.Parse(info[0]),
                    DungeonId = int.Parse(info[1])
                };

                await context.AddAsync(entity);
                await context.SaveChangesAsync();
            }

            return "Successfully seeded the information!";
        }

        return "The table playersDungeons is already seeded!";
    }

    public static async Task<string> SeedPlayersItems(WitherbornDbContext context)
    {
        string path = @"../../../../Witherborn.Core/Services/Implementations/SeedInput/players_items.txt";

        string[] playersItemsInfo = await File.ReadAllLinesAsync(path);

        if (!await context.PlayersItems.AnyAsync())
        {
            foreach (var item in playersItemsInfo)
            {
                string[] info = item.Split('|', StringSplitOptions.RemoveEmptyEntries);

                var entity = new PlayerItem
                {
                    PlayerId = int.Parse(info[0]),
                    ItemId = int.Parse(info[1])
                };

                await context.AddAsync(entity);
                await context.SaveChangesAsync();
            }

            return "Successfully seeded the information!";
        }

        return "The table playersItems is already seeded!";
    }
}
