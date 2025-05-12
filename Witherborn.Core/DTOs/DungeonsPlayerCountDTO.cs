namespace Witherborn.Core.DTOs
{
    public class DungeonsPlayerCountDTO
    {
        public required string DungeonName { get; set; } = null!;
        public required int PlayerCount { get; set; }
    }
}
