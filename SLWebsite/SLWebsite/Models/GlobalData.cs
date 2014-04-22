using System;

namespace SLWebsite.Models
{
    public class GlobalData
    {
        public int Id { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationTitle { get; set; }
        public string ApplicationCredits { get; set; }
        public string BlogTitle { get; set; }
        public bool BlogActive { get; set; }
        public Page MainPage { get; set; }
        public DateTime Created { get; set; }
    }
}