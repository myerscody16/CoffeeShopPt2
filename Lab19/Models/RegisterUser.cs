using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab19.Models
{
    public class User
    {
        [Required]
        [StringLength(30,ErrorMessage ="Input not between 3 and 30 characters", MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Input not between 3 and 30 characters", MinimumLength = 3)]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Input not between 3 and 30 characters", MinimumLength = 3)]
        public string Password { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        [Required]
        public Colors FavoriteColor { get; set; }

    }
}
