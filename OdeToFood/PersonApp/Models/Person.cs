using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonApp.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Display(Name = "Number")]
        [Required]
        public int Number { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
