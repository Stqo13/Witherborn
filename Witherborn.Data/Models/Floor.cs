using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Witherborn.Data.Models;
using static Witherborn.Data.Constraints.FloorConstraints;

public class Floor
{
    [Key]
    public int Id { get; set; }

    public int FloorNumber { get; set; }

    [Required]
    [MaxLength(FloorBossNameMaxLength)]
    public string BossName { get; set; } = null!;

    public int DungeonId { get; set; }

    [ForeignKey(nameof(DungeonId))]
    public virtual Dungeon Dungeon { get; set; } = null!;
}