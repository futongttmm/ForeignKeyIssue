using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte GenreId { get; set; }
        public Genre Genre { get; internal set; }

        [Display(Name = "Number in Stock")]
        public int Number { get; set; }

        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Add Date")]
        public DateTime? AddDate { get; set; }
    }
}