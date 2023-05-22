using OnionLibrary.Domain.DBModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Domain.DBModels
{
    public class RentedBook
    {
        public int Id { get; set; }
        [Required]
        public int BookId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime RentalDate { get; set; }
        public DateTime? DateOfReturn { get; set; }

        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}
