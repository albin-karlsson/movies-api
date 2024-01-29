using System.ComponentModel.DataAnnotations;

namespace TheMovieApi.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Synopsis { get; set; }
    }
}
