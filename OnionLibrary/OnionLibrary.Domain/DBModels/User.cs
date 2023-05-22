﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionLibrary.Domain.DBModels;

namespace OnionLibrary.Domain
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
            RentedBooks = new HashSet<RentedBook>();
        }

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Lastname { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [MinLength(4)]
        [MaxLength(255)]
        public byte[] PasswordHash { get; set; }
        [Required]
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<RentedBook> RentedBooks { get; set; }
    }
}
