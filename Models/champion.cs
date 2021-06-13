using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace leagueChampionStats.Models
{
    public class champion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id {get; set;}

        [Display(Name = "Enter champion name")]
        [Required(ErrorMessage = "{0} is required")]
        public string name {get; set;}

        [Display(Name = "Enter champion role")]
        [Required(ErrorMessage = "{0} is required")]
        public string role {get; set;}

        [Display(Name = "Enter champion type")]
        [Required(ErrorMessage = "{0} is required")]
        public string type {get; set;}

        [Display(Name = "Enter champion region")]
        [Required(ErrorMessage = "{0} is required")]
        public string region {get; set;}
    }
}

