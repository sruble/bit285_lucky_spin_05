using System;
using System.ComponentModel.DataAnnotations;
namespace LuckySpin.Models
{
    public class Player
    {
        [Required (ErrorMessage = "Must enter first name")]
        public string FirstName { get; set; }

        [Required (ErrorMessage = "Pick a number ")]
        [Range(1, 9, ErrorMessage = "pick a number between 1 and 9")]
        public int Luck { get; set; }

        
    }
}