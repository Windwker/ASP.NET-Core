using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonApp.Models
{
    public class Person
    {
        [Display(Name = "Id")]
        [Required,MaxLength(10)]
        public int Id { get; set; }
        [Required,MaxLength(5)]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
