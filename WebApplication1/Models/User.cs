using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class User
    {
        [Required(ErrorMessage ="Name field is required")]
        [StringLength(20,MinimumLength =5,ErrorMessage ="name must be atleast 5 - 20 characters")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Email feild is rrequired")]
        [EmailAddress(ErrorMessage ="invalid email address")]
        public string Email { get; set; }

        [StringLength(5,ErrorMessage = "must be atleast 5 characters")]
        [Required(ErrorMessage ="Password feild is required")]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="not matched with password")]
        public string ConfirmPassword { get; set; }

        [Range(18,99,ErrorMessage ="Age must be between 18 and 99")]
        public int Age { get; set; }

    }
}