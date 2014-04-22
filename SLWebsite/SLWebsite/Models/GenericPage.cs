﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SLWebsite.Models
{
    public class GenericPage
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public virtual Account Creator { get; set; }
        public virtual IList<Resource> Resources { get; set; } 
    }
}