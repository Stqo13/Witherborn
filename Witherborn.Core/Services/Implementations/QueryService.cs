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
                .Select(f => new FloorStrongestEnemyDTO
                {
                    BossName = f.BossName,
                    FloorNumber = f.FloorNumber,
                    StrongestEnemy = f.Dungeon.Enemies
                        .OrderByDescending(e => e.Strength)
                        .Select(e => e.Name)
                        .FirstOrDefault() ?? string.Empty
                })
                .ToListAsync();

            return floors;
        }

        public Task<IEnumerable<PlayerInfoDTO>> GetAllPlayersByDungeonNameAsync(string dungeonName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PlayerFullStatsDTO>> GetAllPlayersFullStatsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DungeonsPlayerCountDTO>> GetDungeonPlayerCountsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EnemyInfoDTO>> GetEnemiesByMinFloorLevelAsync(int minLevel)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PlayerOverallStatsDTO>> GetPlayerOverallStatsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PlayerInfoDTO>> GetPlayersByMinCatacombsLevelAsync(int minLevel)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PlayerInfoDTO>> GetPlayersByOwnedItemAsync(string itemName)
        {
            throw new NotImplementedException();
        }
    }
}
