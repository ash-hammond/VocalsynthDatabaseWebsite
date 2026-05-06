namespace VocalsynthDatabaseWebsite.Models
{
    public class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;

        public ICollection<SongProducer> SongProducers { get; set; } = new List<SongProducer>();
    }
}