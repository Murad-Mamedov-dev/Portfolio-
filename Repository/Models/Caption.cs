using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Caption : BaseEntity
    {
        public int PersonPhotoId { get; set; }

        public PersonPhoto Photo { get; set; }
        [Required]
        [MaxLength(50)]
        public string Logo { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(150)]
        public string Detail { get; set; }
        [Required]
        [MaxLength(50)]
        public string Video { get; set; }
        public ICollection<CaptionIcon> Icons { get; set; }
    }
}
