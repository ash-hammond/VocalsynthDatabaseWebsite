namespace VocalsynthDatabaseWebsite.Models
{
    public class SongVocalSynth
    {
        public int Id { get; set; }
        public int SongId { get; set; }
        public Song Song { get; set; } = default!;
        public int VocalSynthEntryId { get; set; }
        public VocalSynthEntry VocalSynthEntry { get; set; } = default!;
    }
}
