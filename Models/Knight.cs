namespace knights.Models
{
    public class Knight
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Castle { get; set; }
        public string CreatorId { get; set; }
        public Account Creator { get; set; }
        public Castle CastleName { get; set; }
    }
}