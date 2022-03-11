using System.Collections.Generic;
using Enum;

namespace network
{
    public class Category
    {
        public int Id { get; set; }
        public virtual Lesson Lessons { get; set; }
        public virtual IEnumerable<Team> Teams { get; set; }
    }

}