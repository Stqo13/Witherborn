using System.Text;
using Witherborn.Core.DTOs;
using Witherborn.Core.Services.Interfaces;

namespace Witherborn.Controllers
{
    public class QueryController(
        IQueryService queryService)
    {
        public async Task<string> GetPlayersByClassName(string className)
        {
            StringBuilder sb = new StringBuilder();

            var players = await queryService.GetAllPlayersByClassNameAsync(className);

            foreach (var player in players)
            {
                sb.AppendLine($"Username: {player.Username} - Lvl.{player.CatacombsLevel}");
            }

            return sb.ToString();
        }

        public async Task<string> GetPlayersItemsByPlayerUsername(string username)
        {
            StringBuilder sb = new StringBuilder();
            PlayerItemsDTO player;

            try
            {
                player = await queryService.GetAllItemsByPlayerUsernameAsync(username);
            }
            catch (NullReferenceException ex)
            {
                sb.AppendLine(ex.Message);
                return sb.ToString();
            }

            sb.AppendLine($"{player.Username}:");
            sb.AppendLine("--------------------");

            foreach (var item in player.Items)
            {
                sb.AppendLine($"{item}");
            }

            return sb.ToString();
        }

        public async Task<string> GetFloorsStrongestEnemy()
        {
            StringBuilder sb = new StringBuilder();

            var floors = await queryService.GetAllFloorsStrongestEnemyAsync();

            foreach (var floor in floors)
            {
                sb.AppendLine($"Floor {floor.FloorNumber} - {floor.BossName}: {floor.StrongestEnemy}");
            }

            return sb.ToString();
        }

        public async Task<string> GetPlayersFullStats()
        {
            StringBuilder sb = new StringBuilder();

            var players = await queryService.GetAllPlayersFullStatsAsync();

            foreach(var player in players)
            {
                sb.AppendLine($"{player.Username} - {player.ClassName}");

                foreach (var item in player.Items)
                {
                    sb.AppendLine("Owns:");
                    sb.AppendLine($"{item}");
                }

                foreach (var dungeons in player.Dungeons)
                {
                    sb.AppendLine("Participated in:");
                    sb.AppendLine($"{dungeons}");
                }
            }

            return sb.ToString();
        }

        public async Task<string> GetDungeonPlayerCounts()
        {
            StringBuilder sb = new StringBuilder();

            var count = await queryService.GetDungeonPlayerCountsAsync();

            foreach (var item in count)
            {
                sb.AppendLine($"{item.DungeonName} - {item.PlayerCount}");
            }

            return sb.ToString();
        }

        public async Task<string> GetTopPlayersByUniqueItems(int topCount)
        {
            StringBuilder sb = new StringBuilder();

            var players = await queryService.GetTopPlayersByUniqueItemsAsync(topCount);

            foreach (var item in players)
            {
                if (item.ItemCount == 1)
                {
                    sb.AppendLine($"{item.Username} owns: {item.ItemCount} item");
                }
                else if (item.ItemCount > 1)
                {
                    sb.AppendLine($"{item.Username} owns: {item.ItemCount} items");
                }
                else
                {
                    sb.AppendLine($"{item.Username} does not any items");
                }
            }

            return sb.ToString();
        }

        public async Task<string> GetPlayersByDungeonName(string dungeonName)
        {
            StringBuilder sb = new StringBuilder();

            var players = await queryService.GetAllPlayersByDungeonNameAsync(dungeonName);

            foreach (var item in players)
            {
                sb.AppendLine($"{item.Username} - Lvl.{item.CatacombsLevel}");
            }

            return sb.ToString();
        }

        public async Task<string> GetPlayerOverallStats()
        {
            StringBuilder sb = new StringBuilder();

            var players = await queryService.GetPlayerOverallStatsAsync();

            foreach (var player in players)
            {
                sb.AppendLine($"{player.Username} - {player.TotalRuns} Runs");

                if (player.OwnedItems == 1)
                {
                    sb.AppendLine($"Owns: {player.OwnedItems} item");
                }
                else if (player.OwnedItems > 1)
                {
                    sb.AppendLine($"Owns: {player.OwnedItems} items");
                }
                else
                {
                    sb.AppendLine($"Does not own any items!");
                }
            }

            return sb.ToString();
        }

        public async Task<string> GetPlayersByMinCatacombsLevel(int minLevel)
        {
            StringBuilder sb = new StringBuilder();

            var players = await queryService.GetPlayersByMinCatacombsLevelAsync(minLevel);

            foreach (var player in players)
            {
                sb.AppendLine($"{player.Username} - Lvl.{player.CatacombsLevel}");
            }

            return sb.ToString();
        }

        public async Task<string> GetPlayersByOwnedItem(string itemName)
        {
            StringBuilder sb = new StringBuilder();

            var players = await queryService.GetPlayersByOwnedItemAsync(itemName);

            foreach (var player in players)
            {
                sb.AppendLine($"{player.Username} - Lvl.{player.CatacombsLevel}");
            }

            return sb.ToString();
        }
    } 
}
