using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class TeamIcon : BaseEntity
    {
        public int TeamId { get; set; }
        [Required]
        [MaxLength(50)]
        public string EndPoint { get; set; }
        [Required]
        [MaxLength(50)]
        public string Logo { get; set; }
    }
}
