using Microsoft.AspNetCore.Mvc;
using PeopleMVC.Models;
using System.Diagnostics;

namespace PeopleMVC.Controllers
{
    public class HomeController : Controller
    {

        PeopleViewModel peopleViewModel = new PeopleViewModel();

        public IActionResult Index()
        {
            return View(peopleViewModel.people);
        }

        [HttpPost]
        public IActionResult Index(string filterWord)
        {
            
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
        public IActionResult Index(CreatePersonViewModel model)
        {
            if (ModelState.IsValid)
            {
                Person person = new Person(model.Name, model.PhoneNumber, model.City);
                peopleViewModel.people.Add(person);
                ViewBag.Msg = model.Name;
            }
            

            return View(peopleViewModel.people);
        }

    }
}