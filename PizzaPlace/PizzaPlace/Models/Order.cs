﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        public DateTime DateProcessed { get; set; }
        public bool IsProcessed { get; set; }
        public bool IsDelivered { get; set; }
        public DateTime DateDelivered { get; set; }
    }
}
