using System.ComponentModel.DataAnnotations;
namespace Cho4Ex1MovieList.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        [Required(ErrorMessage = "Please enter a name.")]
        public string?Name { get; set; }
        [Required(ErrorMessage ="Please enter a year.")]
        public int? Year { get; set; }
        [Required(ErrorMessage ="Please enter a rating.")]
        [Range(1,5,ErrorMessage ="Rating must be between 1 and 5.")]
        public int? Rating { get; set; }

        [Required (ErrorMessage="Please Enter a genre")]

        public string GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
