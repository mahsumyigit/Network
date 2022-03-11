namespace network
{
    public class Team
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public int TeamDetailsId { get; set; }
        public virtual TeamDetails TeamDetails { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }



    }
}