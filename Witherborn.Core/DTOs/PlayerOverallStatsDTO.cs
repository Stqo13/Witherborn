namespace Witherborn.Core.DTOs
{
    public class PlayerOverallStatsDTO
    {
        public required string Username { get; set; } = null!;
        public required int TotalRuns { get; set; }
        public required int OwnedItems { get; set; }
    }
}
