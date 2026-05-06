namespace VocalsynthDatabaseWebsite.Models
{
    public class SongProducer
    {
        public int Id { get; set; }
        public int SongId { get; set; }
        public Song Song { get; set; } = default!;
        public int ProducerId { get; set; }
        public Producer Producer { get; set; } = default!;
    }
}
