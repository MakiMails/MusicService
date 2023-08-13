namespace MusicService.Models
{
    public class Author
    {
        public int Id { get; set; }
        public List<Album> Albums { get; set; } = new List<Album>();
        public User User { get; set; } = new User();
    }
}
