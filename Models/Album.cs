using System.ComponentModel.DataAnnotations;


namespace MusicStore.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        [Display(Name = "Genre ID")]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        [Display(Name = "Artist ID")]
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        [Display(Name = "Album Art")]
        public string AlbumArtUrl { get; set; }

    }
}