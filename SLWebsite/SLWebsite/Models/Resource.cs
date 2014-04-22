using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SLWebsite.Models
{
    public class Resource
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public string Title { get; set; }
        public string Uri { get; set; }
    }

    public enum ResourceType
    {
        Link,
        Download,
        Image
    }
}