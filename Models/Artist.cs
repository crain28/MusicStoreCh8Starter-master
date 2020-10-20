using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    public class Artist
    {
        [Display(Name="Artist ID")]
        public  int ArtistId { get; set; }
        public  string Name { get; set; }
    }
}