using ExampleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleWebApp
{
    public class PeopleRepository
    {
        List<Person> people = new List<Person>()
        {
            new Person{ FirstName = "Artur", LastName = "Ziemianski"},
            new Person{ FirstName = "Michal", LastName = "sadsa"},
            new Person{ FirstName = "Jan", LastName = "Nowak"}
        };

        public List<Person> People => people;

        public void AddPerson(Person p) 
        {
            people.Add(p);
        }
    }
}
