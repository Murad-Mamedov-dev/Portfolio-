using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class EECart : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Logo { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(150)]
        public string Detail { get; set; }
        [Required]

        public bool IsEdu { get; set; }
        [Required]

        public bool IsExp { get; set; }

    }
}
