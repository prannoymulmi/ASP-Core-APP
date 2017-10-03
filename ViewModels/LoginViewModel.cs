using System;
using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        public String Username { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public String Password { get; set; }
        
        public bool RememberMe { get; set; }
    }
}