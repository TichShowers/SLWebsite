using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SLWebsite.Models
{
    public class Page : GenericPage
    {
        public Page Parent { get; set; }
        public IList<Page> Children { get; set; }
    }
}