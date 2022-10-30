using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iSchoolWebApp.Models
{
    public class LocalAPIModel
    {   //Stores models locally to prevent double-grabs
        public Careers apiEmployment { set; get; }
        public List<Person> apiFaculty { set; get; }

        public List<Person> apiStaff { set; get; }
    }
}
