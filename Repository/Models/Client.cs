using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Client : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(150)]
        public string Detail { get; set; }
        [Required]
        [MaxLength(50)]
        public string Job { get; set; }
        [Required]
        [MaxLength(50)]
        public string Image { get; set; }
        [Required]

        public int StarCount { get; set; }
    }
}
