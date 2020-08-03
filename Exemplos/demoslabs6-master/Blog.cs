using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace demoslabs6
{
    public class Blog
    {
        public int BlogId { get; set; }
        [Required]
        public string Url { get; set; }

        public List<Post> Posts { get; } = new List<Post>();
    }
}