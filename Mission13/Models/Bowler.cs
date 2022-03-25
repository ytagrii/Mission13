using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//Model for the bowler table
namespace Mission13.Models
{
    public class Bowler
    {
        [Key]
        [Required]
        public int BowlerID { get; set; }

        [Required(ErrorMessage = "Please Enter a Last Name" )]
        public string BowlerLastName { get; set; }

        [Required(ErrorMessage = "Please Enter a First Name")]
        public string BowlerFirstName { get; set; }

        [StringLength(1, ErrorMessage = "Middle Initial Can Only be 1 Character Long")]
        public string? BowlerMiddleInit { get; set; }

        [Required(ErrorMessage = "Please Enter an Address")]
        public string BowlerAddress { get; set; }

        [Required(ErrorMessage = "Please Enter a City")]
        public string BowlerCity { get; set; }

        [Required(ErrorMessage = "Please Enter a State")]
        [StringLength(2, ErrorMessage = "State Must be 2 Characters")]
        public string BowlerState { get; set; }

        [Required(ErrorMessage = "Please Enter a Zip Code")]
        public string BowlerZip { get; set; }

        [Required(ErrorMessage = "Please Enter a Phone Number")]
        public string BowlerPhoneNumber { get; set; }

        [Required(ErrorMessage = "Please Enter a Team Name")]
        public int TeamID { get; set; }
        [ForeignKey("TeamID")]
        public Team Team { get; set; }

    }
}
