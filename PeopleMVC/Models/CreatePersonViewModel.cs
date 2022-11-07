using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PeopleMVC.Models
{
    public class CreatePersonViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(9, 13)]
        public string PhoneNumber { get; set; }

        [Required]
        public string City { get; set; }
    }
}
