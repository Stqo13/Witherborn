using System.ComponentModel.DataAnnotations;

using Witherborn.Data.Models;
using static Witherborn.Data.Constraints.ItemConstraints;

public class Item
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(ItemNameMaxLength)]
    public string Name { get; set; } = null!;

    [Required]
    [MaxLength(ItemTypeMaxLength)]
    public string ItemType { get; set; } = null!;

    [Range(ItemPowerRangeStart, ItemPowerRangeEnd)]
    public int Power { get; set; }

    public ICollection<PlayerItem> PlayerItems { get; set; } 
        = new List<PlayerItem>();
}
