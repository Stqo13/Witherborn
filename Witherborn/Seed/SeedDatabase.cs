using Microsoft.EntityFrameworkCore;
using Witherborn.Data;
using Witherborn.Data.Models;

public static class SeedDatabase
{
    public static async Task SeedClasses(WitherbornDbContext context)
    {
        string path = @"../../../SeedInput/classes.txt";

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
        }
        else
        {
            throw new ArgumentException("The table classes is already seeded!");
        }
    }

    public static async Task SeedDungeons(WitherbornDbContext context)
    {
        var path = @"../../../SeedInput/dungeons.txt";

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
        }
        else
        {
            throw new ArgumentException("The table dungeons is already seeded!");
        }
    }

    public static async Task SeedEnemies(WitherbornDbContext context)
    {
        string path = @"../../../SeedInput/enemies.txt";

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
        }
        else
        {
            throw new ArgumentException("The table enemies is already seeded!");
        }
    }


}
