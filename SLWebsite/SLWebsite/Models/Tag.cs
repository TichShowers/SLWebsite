using System.Collections;
using System.Collections.Generic;

namespace SLWebsite.Models
{
    public class Tag
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public IList<Post> Posts { get; set; }
    }
}