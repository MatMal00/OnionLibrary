﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Domain.DBModels
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        public string BookDescription { get; set; }
        [Url]
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int? Quantity { get; set; }
        [Required]
        public bool IsRentable { get; set; }
        public string? Rating { get; set; }
    }
}
