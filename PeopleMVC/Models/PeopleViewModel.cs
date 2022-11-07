namespace PeopleMVC.Models
{
    public class PeopleViewModel
    {
        public List<Person> people = new List<Person>
        {
            new Person("Olof Olofsson", "0733456028", "Göteborg"),
            new Person("Per Persson", "0722456128", "Stockholm"),
            new Person("Anders Andersson", "0736426028", "Malmö"),
            new Person("Rolf Rolfsson", "0733456843", "Borås"),
            new Person("Björn Björnsson", "0733444028", "Göteborg"),
        };
    }
}
