using eMovieTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eMovieTickets.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Display(Name = "Movie Name")]
        public string? Name { get; set; }
        [Display(Name = "Description")]
        public string? Description { get; set; }
        [Display(Name = "Price")]
        public double? Price { get; set; }
        [Display(Name = "Poster Image")]
        public string? ImageURL { get; set; }
        [Display(Name = "Show Starts At")]
        public DateTime? StartDate { get; set; }
        [Display(Name = "Show Ends At")]
        public DateTime? EndDate { get; set; }
        [Display(Name = "My Property")]
        public string? MyProperty { get; set; }
        [Display(Name = "Category")]
        public MovieCategory? MovieCategory { get; set; }

        //Relationships
        public List<Actor_Movie>? Actors_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema? Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer? Producer { get; set; }
    }
}
