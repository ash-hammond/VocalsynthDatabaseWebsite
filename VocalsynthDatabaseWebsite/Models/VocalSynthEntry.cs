namespace VocalsynthDatabaseWebsite.Models
{
    public class VocalSynthEntry
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string VoiceBank { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public string Notes { get; set; } = string.Empty;
    }
}
