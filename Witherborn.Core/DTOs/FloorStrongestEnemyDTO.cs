namespace Witherborn.Core.DTOs
{
    public class FloorStrongestEnemyDTO
    {
        public required string BossName { get; set; } = null!;
        public required int FloorNumber { get; set; }
        public required string StrongestEnemy { get; set; } = null!;
    }
}
