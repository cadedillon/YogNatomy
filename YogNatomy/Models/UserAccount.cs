using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace YogNatomy.Models
{
    public class UserAccount
    {
        [Key]
        public int AccountId { get; set; }
        [Required(ErrorMessage = "Please enter a username.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter your email address.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address.")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Please enter a password.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter your first name.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name.")]
        public string LastName { get; set; }
    }
}