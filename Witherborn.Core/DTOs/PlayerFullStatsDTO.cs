namespace Witherborn.Core.DTOs
{
    public class PlayerFullStatsDTO
    {
        public required string Username { get; set; } = null!;
        public required string ClassName { get; set; } = null!;
        public List<string> Items { get; set; } = new List<string>();
        public List<string> Dungeons { get; set; } = new List<string>();
    }
}
