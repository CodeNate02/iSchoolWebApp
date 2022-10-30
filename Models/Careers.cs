using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iSchoolWebApp.Models
{
    public class Content
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class Introduction
    {
        public string title { get; set; }
        public List<Content> content { get; set; }
    }
    public class TableEntry
    {
        public string employer { get; set; }
        public string degree { get; set; }
        public string city { get; set; }

        public string term { get; set; }

        public string title { get; set; }
        public string startDate { get; set; }
    }
    public class Careers
    {
        public Introduction Introduction { get; set; }
        public List<string> EmployerNames { get; set; }
        public List<string> CareerNames { get; set; }
        public List<TableEntry> CoopTable { get; set; }
        public List<TableEntry> ProTable { get; set; }
    }
    public class CareerRootModel
    {
        public Careers Careers { get; set; }
        public String Title { get; set; }

        public Footer Footer { get; set; }


    }
}
