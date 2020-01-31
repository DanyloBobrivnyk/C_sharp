using FunWithAttr.Attributes;
using FunWithAttr.Models;
using System;
using System.Collections.Generic;

namespace FunWithAttr
{
    [CustomAuthorize("admin")]
    public class PeopleRepository
    {
        public PeopleRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }

        public void ShowProtectedContent()
        {
            CustomAuthorize attr =
             (CustomAuthorize)Attribute
             .GetCustomAttribute(this.GetType(), typeof(CustomAuthorize));

            if (userContext.Role != attr.Role)
            {
                throw new Exception("You have not permission to show people.");
            }

            People.ForEach(item => { Console.WriteLine(item.ToString());  });
        }

        public List<Person> People = new List<Person>
        {
            new Person("Jan", "Nowak"),
            new Person("Michał", "Kowalski"),
            new Person("Barbara", "Test", UserSex.Female)
        };

        private readonly UserContext userContext;
    }
}