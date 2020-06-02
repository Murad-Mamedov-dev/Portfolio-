using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class PersonPhoto : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Photo { get; set; }
        public ICollection<Info> Infos { get; set; }
        public ICollection<Caption> Captions { get; set; }
    }
}
