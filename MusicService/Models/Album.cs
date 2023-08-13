namespace MusicService.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Track> Tracks { get; set; } = new List<Track>();
    }
}
