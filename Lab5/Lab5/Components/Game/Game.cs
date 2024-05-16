using System.ComponentModel.DataAnnotations;

namespace Lab5.Components.Game
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; }  = string.Empty;
        public string Image { get; set; }  = string.Empty;
        public string Genre { get; set; }  = string.Empty;
        public string Platform { get; set; }
        public string Developer { get; set; }  = string.Empty;

        public int? Rating { get; set; }

        public int RatingCount { get; set; }
        
        [DataType(DataType.Date)]
        public DateOnly ReleaseDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        
        public string? Trailer { get; set; }
    }
}
