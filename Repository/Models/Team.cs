using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Team : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Photo { get; set; }
        [Required]
        [MaxLength(50)]
        public string Job { get; set; }
        public ICollection<TeamIcon> TeamIcons { get; set; }
    }
}
