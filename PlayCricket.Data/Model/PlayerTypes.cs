using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlayCricket.Data.Model
{
    public partial class PlayerTypes
    {
        public PlayerTypes()
        {
            Player = new HashSet<Player>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [InverseProperty("PlayerTypeNavigation")]
        public virtual ICollection<Player> Player { get; set; }
    }
}
