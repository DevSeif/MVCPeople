using Microsoft.AspNetCore.Mvc;
using PeopleMVC.Models;
using System.Diagnostics;

namespace PeopleMVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            PeopleViewModel peopleViewModel = new PeopleViewModel();
            return View(peopleViewModel.people);
        }

        [HttpPost]
        public IActionResult Index(string filterWord)
        {
            PeopleViewModel peopleViewModel = new PeopleViewModel();
            List<Person> filterList = new List<Person>();

            if (filterWord == null || filterWord.Trim() == "") { return View(peopleViewModel.people); }
            
            foreach (Person person in peopleViewModel.people)
            {
                if (person.City.Contains(filterWord) || person.Name.Contains(filterWord))
                {
                    filterList.Add(person);
                }
            }
            

            return View(filterList);
        }

        [HttpGet]
        public IActionResult Index(string personName, string personPhone, string personCity)
        {
            //CreatePersonViewModel model = new CreatePersonViewModel();
            Person person = new Person(personName, personPhone, personCity);
            PeopleViewModel peopleViewModel = new PeopleViewModel();
            peopleViewModel.people.Add(person);

            return View(peopleViewModel);
        }

    }
}