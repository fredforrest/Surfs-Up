﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Surfs_Up.Models
{
    [Index(nameof(Email), IsUnique = true)]
    [Index(nameof(UserName), IsUnique = true)]
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Indtast gyldigt navn")]
        [MaxLength(50, ErrorMessage ="Navn må maks være 50 tegn")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Indtats venligst et gyldigt Email")]
        [MaxLength(50, ErrorMessage = "Email må maks være 50 tegn")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Indtast gyldig Brugernavn")]
        [MaxLength(20, ErrorMessage = "Brugernavn må maks være 20 tegn")]

        public string UserName { get; set; }
        [Required(ErrorMessage = "Indtast korrekt adgangskode")]
        [MaxLength(25, ErrorMessage = "Adgangskode må maks være 25 tegn")]
        [MinLength(8, ErrorMessage = "Adgangskode skal være minimum 8 tegn")]

        public string Password { get; set; }


    }
}
