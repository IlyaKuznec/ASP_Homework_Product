﻿using System.ComponentModel.DataAnnotations;

namespace ASP_Homework_Product.Models
{
    public class Register
    {

        [Required]
        [EmailAddress]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}

