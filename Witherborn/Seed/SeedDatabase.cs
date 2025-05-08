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
            }
        }
    }
}
