using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleLoginReg.Models
{
    public class Login
    {
       [Required]
       [EmailAddress]
       public string LEmail { get; set; }

       [Required]
       [DataType(DataType.Password)]
       [MinLength(8)]
       public string LPassword { get; set; }
    }
}