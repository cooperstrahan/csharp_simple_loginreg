using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleLoginReg.Models
{
    public class Match : ValidationAttribute
    {
        // protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        // {
        //     if (Register.Password != Register.PasswordConfirm)
        //     {
        //         return new ValidationResult("The Passwords Must Match!");
        //     }
        //     else
        //     {
        //         return ValidationResult.Success;
        //     }
        // }
    }
    public class Register
    {
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }


        [DataType(DataType.Password)]
        [CompareAttribute("Password", ErrorMessage = "Passwords Must Match!")]
        public string PasswordConfirm { get; set; }   
    }
}