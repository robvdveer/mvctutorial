using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCTutorial.Models.DataModel
{
    public class Account
    {
        public int ID { get; set; }
        [Required]
        [StringLength(maximumLength:24, MinimumLength = 8)]
        [Display(Name = "Gebruikersnaam")]
        public string Username { get; set; }

        [Required]
        [RegularExpression("[A-Z]*")]
        public string Displayname { get; set; }
        public DateTime Created { get; set; }
        public bool IsEnabled { get; set; }
    }
}