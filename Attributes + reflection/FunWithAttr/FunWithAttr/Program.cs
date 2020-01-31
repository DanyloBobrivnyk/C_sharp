using FunWithAttr.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;

namespace FunWithAttr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Role: ");
            var role = Console.ReadLine();

            var services = new ServiceCollection();
            services.AddTransient<UserContext>(p =>
            {
                return new UserContext(role);
            });
            services.AddTransient<PeopleRepository>();

            var provider = services.BuildServiceProvider();

            var srvc = provider.GetService<PeopleRepository>();
            srvc.ShowProtectedContent();


            var properties = typeof(Person).GetProperties();

            foreach (var item in properties)
            {
                Console.WriteLine(item.Name);
            }

            PropertyInfo prop =
                 typeof(Person).GetProperty("PrivateProperty",
                 BindingFlags.NonPublic | BindingFlags.Instance);
            prop.SetValue(srvc.People.First(), "new value");
            string val = prop.GetValue(srvc.People.First()).ToString();
            Console.WriteLine(val);


            Console.ReadKey();
        }
    }
}
