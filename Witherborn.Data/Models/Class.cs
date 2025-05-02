using System.ComponentModel.DataAnnotations;

using static Witherborn.Data.Constraints.ClassConstraints;

namespace Witherborn.Data.Models
{
    public class Class
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ClassTypeMaxLength)]
        public string Type { get; set; } = null!;

        [MaxLength(ClassDescriptionMaxLength)]
        public string? Description { get; set; }

        public virtual ICollection<Player> Players { get; set; }
            = new List<Player>();
    }
}
