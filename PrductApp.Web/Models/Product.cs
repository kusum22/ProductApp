﻿using System.ComponentModel.DataAnnotations;

namespace ProductApp.Web.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
       
        public decimal? Price { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Only positive number allowed.")]
        public int? Stock { get; set; }
        [Required]
        public string Color { get; set; }
    }
}
