using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Witherborn.Data.Models
{
    [PrimaryKey(nameof(PlayerId), nameof(ItemId))]
    public class PlayerItem
    {
        public int PlayerId { get; set; }

        [ForeignKey(nameof(PlayerId))]
        public virtual Player Player { get; set; } = null!;

        public int ItemId { get; set; }

        [ForeignKey(nameof(ItemId))]
        public virtual Item Item { get; set; } = null!;
    }
}
