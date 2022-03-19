using System.Collections.Generic;
using Enum;

namespace network
{
    public class Category
    {
        public int Id { get; set; }
        public virtual Lesson Lessons { get; set; }
        public int TeamDetailsId { get; set; }
        public TeamDetails TeamDetails { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }

}