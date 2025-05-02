using System.ComponentModel.DataAnnotations;

using static Witherborn.Data.Constraints.DungeonConstraints;

namespace Witherborn.Data.Models
{
    public class Dungeon
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(DungeonNameMaxLength)]
        public string Name { get; set; } = null!;

        [Range(DungeonDiffLevelRangeStart, DungeonDiffLevelRangeEnd)]
        public int DifficultyLevel { get; set; }

        [MaxLength(DungeonTypeMaxLength)]
        public string? Type { get; set; }

        public ICollection<Enemy> Enemies { get; set; }
            = new List<Enemy>();
        public ICollection<Floor> Floors { get; set; }
            = new HashSet<Floor>();
        public ICollection<PlayerDungeon> PlayerDungeons { get; set; }
            = new List<PlayerDungeon>();
    }
}
