namespace network
{
    public class Category
    {
        public int CategoryId { get; set; }
        public enum Lesson { yoga,dance,sport,theatre }
        public Lesson lesson { get; set; }
        public Team team{get;set;}
    }
}