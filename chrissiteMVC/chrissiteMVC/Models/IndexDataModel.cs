using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace chrissiteMVC.Models
{
    public class IndexDataModel
    {
        public string Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Occupation { get; set; }
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
        [Required]
        public string Picture { get; set; } //change to byte[]
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(15)]
        public string PhoneNo { get; set; }
        [Required]
        public string Cv { get; set; } //change to byte
    }
}
