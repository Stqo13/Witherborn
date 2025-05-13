using Microsoft.EntityFrameworkCore;
using Witherborn.Core.DTOs;
using Witherborn.Core.Services.Interfaces;
using Witherborn.Data;

namespace Witherborn.Core.Services.Implementations
{
    public class QueryService(
        WitherbornDbContext context
        ) : IQueryService
    {
        public async Task<IEnumerable<PlayerInfoDTO>> GetAllPlayersByClassNameAsync(string className)
        {
            var players = await context.Players
                .Where(p => p.Class.Type == className)
                .Select(p => new PlayerInfoDTO
                {
                    Username = p.Username,
                    CatacombsLevel = p.CatacombsLevel
                })
                .ToListAsync();

            return players;
        }

        public async Task<PlayerItemsDTO> GetAllItemsByPlayerUsernameAsync(string username)
        {
            var player = await context.Players
                .Where(p => p.Username == username)
                .Select(p => new PlayerItemsDTO
                {
                    Username = p.Username,
                    Items = p.PlayerItems
                        .Select(pi => pi.Item.Name)
                        .ToList()
                })
                .FirstOrDefaultAsync();

            if (player is null)
            {
                throw new NullReferenceException("Invalid player username!");
            }

            return player;
        }

        public async Task<IEnumerable<FloorStrongestEnemyDTO>> GetAllFloorsStrongestEnemyAsync()
        {
            var floors = await context.Floors
                .Include(f => f.Dungeon)
                .ThenInclude(f => f.Enemies) 
                .Select(f => new FloorStrongestEnemyDTO
                {       
                    FloorNumber = f.FloorNumber,
                    BossName = f.BossName,
                    StrongestEnemy = f.Dungeon.Enemies
                        .OrderByDescending(e => e.Strength)
                        .Select(e => e.Name)
                        .FirstOrDefault() ?? "No enemies on this floor"
                })
                .ToListAsync();

            return floors;
        }

        public async Task<IEnumerable<PlayerFullStatsDTO>> GetAllPlayersFullStatsAsync()
        {
            var players = await context.Players
                .Select(p => new PlayerFullStatsDTO
                {
                    Username = p.Username,
                    ClassName = p.Class.Type,
                    Items = p.PlayerItems
                        .Select(pi => pi.Item.Name)
                        .ToList(),
                    Dungeons = p.PlayerDungeons
                        .Select(pd => pd.Dungeon.Name)
                        .ToList()
                })
                .ToListAsync();

            return players;
        }

        public async Task<IEnumerable<DungeonsPlayerCountDTO>> GetDungeonPlayerCountsAsync()
        {
            var count = await context.Dungeons
                .Select(d => new DungeonsPlayerCountDTO
                {
                    DungeonName = d.Name,
                    PlayerCount = d.PlayerDungeons.Count
                })
                .ToListAsync();

            return count;
        }

        public async Task<IEnumerable<PlayerItemCountDTO>> GetTopPlayersByUniqueItemsAsync(int topCount)
        {
            var players = await context.Players
                .Select(p => new PlayerItemCountDTO
                {
                    Username = p.Username,
                    ItemCount = p.PlayerItems.Count()
                })
                .OrderByDescending(p => p.ItemCount)
                .Take(topCount)
                .ToListAsync();

            return players;
        }

        public async Task<IEnumerable<PlayerInfoDTO>> GetAllPlayersByDungeonNameAsync(string dungeonName)
        {
            var players = await context.Players
                .Where(p => p.PlayerDungeons.Any(pd => pd.Dungeon.Name == dungeonName))
                .Select(p => new PlayerInfoDTO
                {
                    Username = p.Username,
                    CatacombsLevel = p.CatacombsLevel
                })
                .ToListAsync();

            return players;
        }

        public async Task<IEnumerable<PlayerOverallStatsDTO>> GetPlayerOverallStatsAsync()
        {
            var players = await context.Players
                .Select(p => new PlayerOverallStatsDTO
                {
                    Username = p.Username,
                    TotalRuns = p.RunCompletions,
                    OwnedItems = p.PlayerItems.Count
                })
                .ToListAsync();

            return players;
        }

        public async Task<IEnumerable<PlayerInfoDTO>> GetPlayersByMinCatacombsLevelAsync(int minLevel)
        {
            var players = await context.Players
                .Where(p => p.CatacombsLevel >= minLevel)
                .Select(p => new PlayerInfoDTO
                {
                    Username = p.Username,
                    CatacombsLevel = p.CatacombsLevel
                })
                .ToListAsync();

            return players;
        }

        public async Task<IEnumerable<PlayerInfoDTO>> GetPlayersByOwnedItemAsync(string itemName)
        {
            var players = await context.Players
                .Where(p => p.PlayerItems.Any(pi => pi.Item.Name == itemName))
                .Select(p => new PlayerInfoDTO
                {
                    Username = p.Username,
                    CatacombsLevel = p.CatacombsLevel
                })
                .ToListAsync();

            return players;
        }
    }
}
