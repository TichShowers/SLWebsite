using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SLWebsite.Models
{
    public class Post : GenericPage
    {
        public IList<Tag> Tags { get; set; }
    }
}