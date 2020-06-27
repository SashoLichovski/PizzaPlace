using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string EmailAdress { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }

    }
}
