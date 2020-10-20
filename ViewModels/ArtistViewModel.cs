using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.ViewModels
{
    public class ArtistViewModel
    {

        public List<Album> Album { get; set; }
        public List<Artist> Artist { get; set; }

    }
}
