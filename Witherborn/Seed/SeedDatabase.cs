using Microsoft.Data.SqlClient.DataClassification;
using Witherborn.Data;
using Witherborn.Data.Models;

public static class SeedDatabase
{
    public static void Seed(WitherbornDbContext context)
    {
        string basePath = AppDomain.CurrentDomain.BaseDirectory;
        string seedFolder = Path.Combine(basePath, "SeedData");

        if (!context.Items.Any())
        {
            var lines = File.ReadAllLines(Path.Combine(seedFolder, "items.txt"));
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                context.Items.Add(new Item
                {
                    Name = parts[0],
                    ItemType = parts[1],
                    Power = int.Parse(parts[2])
                });
            }
        }
        
        if (!context.Classes.Any())
        {
            var lines = File.ReadAllLines(Path.Combine(seedFolder, "classes.txt"));
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                context.Classes.Add(new Class
                {
                    Type = parts[0],
                    Description = parts[1]
                });
            }
        }

        if (!context.Players.Any())
        {
            var lines = File.ReadAllLines(Path.Combine(seedFolder, "players.txt"));
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                context.Players.Add(new Player
                {
                    Username = parts[0],
                    CatacombsLevel = int.Parse(parts[1]),
                    RunCompletions = int.Parse(parts[2]),
                    ClassId = int.Parse(parts[3])
                });
            }
        }

        if (!context.Dungeons.Any())
        {
            var lines = File.ReadAllLines(Path.Combine(seedFolder, "dungeons.txt"));
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                context.Dungeons.Add(new Dungeon
                {
                    Name = parts[0],
                    DifficultyLevel = int.Parse(parts[1]),
                    Type = parts[2]
                });
            }
        }

        if (!context.Enemies.Any())
        {
            var lines = File.ReadAllLines(Path.Combine(seedFolder, "enemies.txt"));
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                context.Enemies.Add(new Enemy
                {
                    Name = parts[0],
                    Strength = int.Parse(parts[1]),
                    DungeonId = int.Parse(parts[2])
                });
            }
        }

        if (!context.Floors.Any())
        {
            var lines = File.ReadAllLines(Path.Combine(seedFolder, "floors.txt"));
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                context.Floors.Add(new Floor
                {
                    FloorNumber = int.Parse(parts[0]),
                    BossName = parts[1],
                    DungeonId = int.Parse(parts[2])
                });
            }
        }

        context.SaveChanges();
    }
}
