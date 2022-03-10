namespace network
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<TeamDetails> TeamDetails { get; set; }



    }
}