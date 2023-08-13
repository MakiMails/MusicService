namespace MusicService.Models
{
    public class User
    {
        public int Id { get; set; } 
        public string Nick { get; set; } = string.Empty;
        public List<Track> LikeTracks { get; set; } = new List<Track>();
        public List<Track> NotLikeTrack { get; set; } = new List<Track>();
        public bool IsAuthor { get; set; } = false;
    }
}