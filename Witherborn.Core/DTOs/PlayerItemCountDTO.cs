namespace Witherborn.Core.DTOs
{
    public class PlayerItemCountDTO
    {
        public required string Username { get; set; } = null!;
        public required int ItemCount { get; set; }
    }
}
