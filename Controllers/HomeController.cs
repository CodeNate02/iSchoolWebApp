using iSchoolWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using iSchoolWebApp.Services;

namespace iSchoolWebApp.Controllers
{
    public class HomeController : Controller
    {
        private static readonly GetAll iSchoolApi = new GetAll() { apiSource = "http://www.ist.rit.edu/api/" };
        private static readonly Footer iSchoolFooter = iSchoolApi.GoGet<Footer>("Footer", false).Result;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            //load the data...
            //tell the instance to go get the data...

            //var loadedAbout = await iSchoolApi.GoGetList<About>("about").about;

            Task<About> loadAbout = iSchoolApi.GoGet<About>("about", false);
            Task<List<Statistic>> loadStats = iSchoolApi.GetList<Statistic>("employment/degreeStatistics/statistics");

            await Task.WhenAll(loadStats, loadAbout);

            //take the loadedAbout and populate the model
            var aboutModel = new AboutRootModel()
            {
                Title = "About our iSchool",
                About = loadAbout.Result,
                Stats = loadStats.Result,
                Footer = iSchoolFooter
            };
            //call the view
            return View(aboutModel);
        }

        public async Task<IActionResult> FacultyStaff()
        {
            //get the data
            Task<List<Person>> GetFList = iSchoolApi.GetList<Person>("people/faculty");
            Task<List<Person>> GetSList = iSchoolApi.GetList<Person>("people/staff");
            await Task.WhenAll(GetFList, GetSList);  //Wait for all tasks to complete
            //populate the model

            var facultyModel = new FacultyStaffRootModel() //Populate model
            {
                Title = "iSchool Faculty & Staff",
                Faculty = GetFList.Result.ToList(), //Translate result to list
                Staff = GetSList.Result.ToList(),
                Footer = iSchoolFooter
            };
            //send to the view
            return View(facultyModel);
        }

        public async Task<IActionResult> Careers()
        {
            Task<Introduction> GetIntro = iSchoolApi.GoGet<Introduction>("employment/introduction", true);
            Task<List<String>> GetEmployers = iSchoolApi.GetList<String>("employment/employers/employerNames");
            Task<List<String>> GetCareers = iSchoolApi.GetList<String>("employment/careers/careerNames");
            Task<List<TableEntry>> GetCoopTable = iSchoolApi.GetList<TableEntry>("employment/coopTable/coopInformation");
            Task<List<TableEntry>> GetEmpTable = iSchoolApi.GetList<TableEntry>("employment/employmentTable/professionalEmploymentInformation");
            //Construct model
            await Task.WhenAll(GetIntro, GetEmployers, GetCareers, GetCoopTable, GetEmpTable);
            Console.WriteLine(GetCoopTable.Result[0].city);
            var employmentModel = new CareerRootModel()
            {
                Title = "Employment",

                Careers = new Careers()
                {
                    Introduction = GetIntro.Result,
                    EmployerNames = GetEmployers.Result,
                    CareerNames = GetCareers.Result,
                    CoopTable = GetCoopTable.Result,
                    ProTable = GetEmpTable.Result
                },
                Footer = iSchoolFooter
            };

            return View(employmentModel);
        }
        public async Task<IActionResult> Academics()
        {
            Task<MajorList> GetMajors = iSchoolApi.GoGet<MajorList>("degrees", false);
            Task<List<UgMinor>> GetMinors = iSchoolApi.GetList<UgMinor>("minors");
            Task<List<Course>> GetCourses = iSchoolApi.GoGet<List<Course>>("course", false);
            //Construct model
            await Task.WhenAll(GetMajors, GetMinors, GetCourses);

            List<UgMinor> minors = GetMinors.Result;
            foreach(UgMinor minor in minors)
            {  //Sweep through each minor and remove the Minor Code from the end 
                minor.title = minor.title.Replace(" ("+minor.name+")","");
                //Remove the redundant "Minor" from titles that have it
                minor.title = minor.title.Replace("Minor", "");
            }
            Dictionary<String, Course> d = new Dictionary<string, Course>();
            foreach( Course c in GetCourses.Result)
            {
                d.Add(c.courseID, c);
            }
            var academicsModel = new AcademicsRootModel()
            {
                title = "iSchool Degrees & Programs",
                minors = minors,
                degrees = GetMajors.Result,
                courses = d,
                Footer = iSchoolFooter
                
            };

            return View(academicsModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}