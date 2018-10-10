using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesManager.Models
{
    public class Devices
    {
        [Display(Name = "Serial Number")]
        [Required]
        [Key]
        public int SerialNumber { get; set; }
        [Display(Name = "Device Name")]
        [Required]
        public string DeviceName { get; set; }
        [Display(Name = "Is in use?")]
        [Required]
        public bool InUse { get; set; }
        [Display(Name = "Description")]
        [Required]
        public string Description { get; set; }
    }
}
