using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Domain
{
    internal class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Author { get; set; } = string.Empty;
        public string BookDescription { get; set; } = string.Empty;
        [Url]
        public string ImageUrl { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int? Quantity { get; set; }
        [Required]
        public bool IsRentable { get; set; }
        public string? Rating { get; set; }
    }
}
