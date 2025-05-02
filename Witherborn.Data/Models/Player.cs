using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using static Witherborn.Data.Constraints.PlayerConstraints;

namespace Witherborn.Data.Models
{
    public class Player
    {
        [Key]   
        public int Id { get; set; }

        [Required]
        [MaxLength(PlayerUsernameMaxLength)]
        public string Username { get; set; } = null!;

        [Required]
        public int CatacombsLevel { get; set; }

        public int ClassId { get; set; }

        [ForeignKey(nameof(ClassId))]
        public virtual Class Class { get; set; } = null!; 

        [Required]
        public int RunCompletions { get; set; }

        public virtual ICollection<PlayerItem> PlayerItems { get; set; }
            = new List<PlayerItem>();

        public virtual ICollection<PlayerDungeon> PlayerDungeons { get; set; }
            = new List<PlayerDungeon>();
    }
}
