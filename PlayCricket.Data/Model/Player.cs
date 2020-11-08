using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlayCricket.Data.Model
{
    public partial class Player
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        public int? Country { get; set; }
        public int? PlayerType { get; set; }
        public int? BowlingType { get; set; }

        [ForeignKey("BowlingType")]
        [InverseProperty("Player")]
        public virtual BowlingTypes BowlingTypeNavigation { get; set; }
        [ForeignKey("PlayerType")]
        [InverseProperty("Player")]
        public virtual PlayerTypes PlayerTypeNavigation { get; set; }
    }
}
