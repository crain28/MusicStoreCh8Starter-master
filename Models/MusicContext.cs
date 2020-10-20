using Microsoft.EntityFrameworkCore;

namespace MusicStore.Models
{
    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext>options) : base(options)
        {}

        public DbSet<Album> Albums { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().HasData(
                new Artist { ArtistId=1, Name = "Panic at the Disco" },
                new Artist { ArtistId = 2, Name = "Imagine Dragons" },
                new Artist { ArtistId = 3, Name = "Greta Van Fleet" },
                new Artist { ArtistId = 4, Name = "Twenty One Pilots" },
                new Artist { ArtistId = 5, Name = "Rolling Stones" },
                new Artist { ArtistId = 6, Name = "Led Zepplin" },
                new Artist { ArtistId = 7, Name = "Cheap Trick" },
                new Artist { ArtistId = 8, Name = "Pink" },
                new Artist { ArtistId = 9, Name = "Bob Marley and the Wailers" },
                new Artist { ArtistId = 10, Name = "Fleetwood Mac" }
                );
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId=1, Name = "Alternative" },
                new Genre { GenreId = 2, Name = "Blues" },
                new Genre { GenreId = 3, Name = "Classical" },
                new Genre { GenreId = 4, Name = "Country" },
                new Genre { GenreId = 5, Name = "Dance" },
                new Genre { GenreId = 6, Name = "Electronic" },
                new Genre { GenreId = 7, Name = "Hip Hop" },
                new Genre { GenreId = 8, Name = "Jazz" },
                new Genre { GenreId = 9, Name = "Metal" },
                new Genre { GenreId = 10, Name = "Pop" },
                new Genre { GenreId = 11, Name = "R&B/Soul" },
                new Genre { GenreId = 12, Name = "Raggae" },
                new Genre { GenreId = 13, Name = "Rock" }
                );
            modelBuilder.Entity<Album>().HasData(
                new Album { AlbumId=1, GenreId = 1, ArtistId = 1, Title = "Pray for the Wicked", Price = 9.99m, AlbumArtUrl = "" },
                new Album { AlbumId = 2, GenreId = 1, ArtistId = 1, Title = "Death of a Bachelor", Price = 7.99m, AlbumArtUrl = "" },
                new Album { AlbumId = 3, GenreId = 1, ArtistId = 2, Title = "Origins", Price = 11.99m, AlbumArtUrl = "" },
                new Album { AlbumId = 4, GenreId = 1, ArtistId = 2, Title = "Evolve", Price = 9.99m, AlbumArtUrl = "" },
                new Album { AlbumId = 5, GenreId = 13, ArtistId = 3, Title = "From the Fires", Price = 6.99m, AlbumArtUrl = "" },
                new Album { AlbumId = 6, GenreId = 13, ArtistId = 3, Title = "Anthem of the Peaceful Army", Price = 6.99m, AlbumArtUrl = "" },
                new Album { AlbumId = 7, GenreId = 13, ArtistId = 5, Title = "Hot Rocks 1964-1971", Price = 14.99m, AlbumArtUrl = "" },
                new Album { AlbumId = 8, GenreId = 13, ArtistId = 10, Title = "Rumours", Price = 6.99m, AlbumArtUrl = "" },
                new Album { AlbumId = 9, GenreId = 12, ArtistId = 9, Title = "Legend", Price = 9.99m, AlbumArtUrl = "" },
                new Album { AlbumId = 10, GenreId = 12, ArtistId = 9, Title = "Exodus", Price = 7.99m, AlbumArtUrl = "" },
                new Album { AlbumId = 11, GenreId = 13, ArtistId = 7, Title = "Authorized Greatest Hits", Price = 10.99m, AlbumArtUrl = "" }
            );
          }
    }

 }
