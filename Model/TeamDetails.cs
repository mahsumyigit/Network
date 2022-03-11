namespace network
{
    public class TeamDetails
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Salary { get; set; }
        public string StartingDate { get; set; }
        public string EndingDate { get; set; }
        public int TeamId { get; set; }
        public virtual Team Teams { get; set; }
        
    }
}