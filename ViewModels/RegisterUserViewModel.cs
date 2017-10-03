using System;
using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class RegisterUserViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        public String Username { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public String Password { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public String ConfirmPassword { get; set; }
    }
}