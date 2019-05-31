using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace chrissiteMVC.Models
{
    public class ProjectDataModel
    {
        [Key]
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [StringLength(255)]
        public string Link { get; set; }
        [Required]
        public byte[] Image { get; set; }
        [Required]
        [StringLength(255)]
        public string GithubLink { get; set; }
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
    }
}
