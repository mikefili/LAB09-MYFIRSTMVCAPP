using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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

        public static List<TimePerson> GetPersons(int begYear, int endYear)
        {
            //read in the file
            //File.ReadAllLines (in an array)
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../wwwroot/personOfTheYear.csv");
            var csvData = File.ReadAllLines(path).Skip(1);

            // iterate through that array and set the values appropriately to a new TimePerson Object
            List<TimePerson> timePeople = new List<TimePerson>();
            foreach (var item in csvData)
            {
                string[] data = item.Split(',');
                TimePerson person = new TimePerson();
                person.Year = Convert.ToInt32(data[0]);
                person.Honor = (data[1] == "" ? "N/A" : data[1]);
                person.Name = (data[2] == "" ? "N/A" : data[2]);
                person.Country = (data[3] == "" ? "N/A" : data[3]);
                person.BirthYear = (data[4] == "" ? 0 : Convert.ToInt32(data[4]));
                person.DeathYear = (data[5] == "" ? 0 : Convert.ToInt32(data[5]));
                person.Title = (data[6] == "" ? "N/A" : data[6]);
                person.Category = (data[7] == "" ? "N/A" : data[7]);
                person.Context = (data[8] == "" ? "N/A" : data[8]);
                timePeople.Add(person);
            }

            // CSV is comma delimited

            // create the full list of people from the csv file

            // THEN do the LINQ query (with Lambda) to filter


            List<TimePerson> listOfPeople = timePeople.Where(person => (person.Year >= begYear) && (person.Year <= endYear)).ToList();
            return listOfPeople;
        }
    }
}
