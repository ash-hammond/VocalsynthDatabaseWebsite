namespace VocalsynthDatabaseWebsite.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string YouTubeUrl { get; set; } = string.Empty;
        public string Lyrics { get; set; } = string.Empty;
        public DateTime UploadDate { get; set; }

        public ICollection<SongProducer> SongProducers { get; set; } = new List<SongProducer>();
        public ICollection<SongVocalSynth> SongVocalSynths { get; set; } = new List<SongVocalSynth>();
    }
}
