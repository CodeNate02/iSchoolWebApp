using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iSchoolWebApp.Models
{
    public class About
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Quote { get; set; }
        public string QuoteAuthor { get; set; }
    }

    public class Statistic
    {
        public string value { get; set; }
        public string description { get; set; }
    }

    public class AboutRootModel
    {
        //access to the object
        public About About { get; set; }
        public List<Statistic> Stats { get; set; }
        //other stuff I might want to add - like the title of the page
        public string Title { get; set; }

        public Footer Footer { get; set; }
    }

}
