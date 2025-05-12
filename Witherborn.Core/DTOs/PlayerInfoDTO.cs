namespace Witherborn.Core.DTOs
{
    public class PlayerInfoDTO
    {
        public required string Username { get; set; } = null!;
        public required int CatacombsLevel { get; set; }
    }
}
