using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Witherborn.Data.Models;
using static Witherborn.Data.Constraints.EnemyConstraints;

public class Enemy
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(EnemyNameMaxLength)]
    public string Name { get; set; } = null!;

    [Range(EnemtStrengthRangeStart, EnemtStrengthRangeEnd)]
    public int Strength { get; set; }

    public int DungeonId { get; set; }

    [ForeignKey(nameof(DungeonId))]
    public virtual Dungeon Dungeon { get; set; } = null!;
}