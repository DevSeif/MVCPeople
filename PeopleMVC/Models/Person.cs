using System.ComponentModel.DataAnnotations;

namespace PeopleMVC.Models
{
    public class Person
    {
        public string Name { get; set; }

        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public string City { get; set; }

        public Person(string name, string phoneNumber, string city)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            City = city;
        }
    }
}
