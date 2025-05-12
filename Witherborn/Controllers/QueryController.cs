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
    } 
}
