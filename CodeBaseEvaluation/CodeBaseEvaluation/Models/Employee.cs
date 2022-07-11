using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBaseEvaluation.Models
{
    public class Employee
    {
        [Key]
        public string FName { get; set; }
        [Required]
        public string LName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Location { get; set; }
    }
}
