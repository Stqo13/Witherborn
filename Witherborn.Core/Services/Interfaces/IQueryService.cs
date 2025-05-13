using Witherborn.Core.DTOs;

namespace Witherborn.Core.Services.Interfaces
{
    public interface IQueryService
    {
        Task<IEnumerable<PlayerInfoDTO>> GetAllPlayersByClassNameAsync(string className);
        Task<PlayerItemsDTO> GetAllItemsByPlayerUsernameAsync(string username);
        Task<IEnumerable<PlayerInfoDTO>> GetAllPlayersByDungeonNameAsync(string dungeonName);
        Task<IEnumerable<FloorStrongestEnemyDTO>> GetAllFloorsStrongestEnemyAsync();
        Task<IEnumerable<PlayerFullStatsDTO>> GetAllPlayersFullStatsAsync();
        Task<IEnumerable<DungeonsPlayerCountDTO>> GetDungeonPlayerCountsAsync();
        Task<IEnumerable<PlayerItemCountDTO>> GetTopPlayersByUniqueItemsAsync(int topCount);
        Task<IEnumerable<PlayerOverallStatsDTO>> GetPlayerOverallStatsAsync();
        Task<IEnumerable<PlayerInfoDTO>> GetPlayersByMinCatacombsLevelAsync(int minLevel);
        Task<IEnumerable<PlayerInfoDTO>> GetPlayersByOwnedItemAsync(string itemName);
    }
}
