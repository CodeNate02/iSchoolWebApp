using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iSchoolWebApp.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Person
    {
        public string username { get; set; }
        public string name { get; set; }
        public string tagline { get; set; }
        public string imagePath { get; set; }
        public string title { get; set; }
        public string interestArea { get; set; }
        public string office { get; set; }
        public string website { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string twitter { get; set; }
        public string facebook { get; set; }
    }
    public class FacultyStaffRootModel
    {
        public List<Person> Staff { get; set; }
        public List<Person> Faculty { get; set; }
        public String Title { get; set; }
        public Footer Footer { get; set; }

        public Dictionary<String, String> Interests = new Dictionary<String, String>()
        {
            {"cit","Computing & Information Technologies"},
            {"nsa","Networking, Security, & Administration"},
            {"ist","Information Sciences & Technologies"},
            {"hci","Human-Computer Interaction"},
            {"hcc","Human-Centered Computing"},
            {"wmc","Web & Mobile Computing"},
            {"hi","Hardware Integration"}
        };
    }
}
