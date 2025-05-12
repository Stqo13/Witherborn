namespace Witherborn.Core.DTOs
{
    public class PlayerItemsDTO
    {
        public required string Username { get; set; } = null!;
        public List<string> Items { get; set; } = new List<string>();
    }
}
