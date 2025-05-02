using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Witherborn.Data.Models
{
    [PrimaryKey(nameof(PlayerId), nameof(DungeonId))]
    public class PlayerDungeon
    {
        public int PlayerId { get; set; }

        [ForeignKey(nameof(PlayerId))]
        public virtual Player Player { get; set; } = null!;

        public int DungeonId { get; set; }

        [ForeignKey(nameof(DungeonId))]
        public virtual Dungeon Dungeon { get; set; } = null!;

        public bool IsCompleted { get; set; } = false;
    }
}
