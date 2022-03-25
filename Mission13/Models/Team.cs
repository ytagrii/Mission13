using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//team model
namespace Mission13.Models
{
    public class Team
    {
        [Key]
        [Required]
        public int TeamID { get; set; }

        [Required]
        public string TeamName {get; set;}

        [Required]
        public int CaptainID { get; set; }

        [ForeignKey("CaptainID")]
        public Bowler Bowler { get; set; }
    }
}
