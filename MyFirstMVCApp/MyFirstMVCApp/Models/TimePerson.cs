using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVCApp.Models
{
    public class TimePerson
    {
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }
    }

    public static List<TimePerson> GetPersons(int begYear, int endYear)
    {
        //read in the file
        //File.ReadAllLines (in an array)

        // iterate through that array and set the values appropriately to a new TimePerson Object

        // CSV is comma delimited

        // create the full list of people from the csv file

        // THEN do the LINQ query (with Lambda) to filter


        List<TimePerson> listOfPeople = people.Where(p => (p.Year >= begYear) && (p.Year <= endYear)).ToList();
    }
}
