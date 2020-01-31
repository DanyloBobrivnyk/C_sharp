using System;

namespace ExampleWebApp.Models
{
    public class Person
    {
        public Person()
        {
            PersonId = Guid.NewGuid();
        }

        public Guid PersonId { get; protected set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}