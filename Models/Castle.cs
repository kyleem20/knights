namespace knights.Models
{
    public class Castle
    {
        public string Name { get; set; }
        public string CreatorId { get; set; }
        public Account Creator { get; set; }
    }
}
