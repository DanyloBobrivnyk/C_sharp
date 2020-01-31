using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleWebApp.Models
{
    public class CategoryEntity
    {
        public long Id { get; protected set; }
        public string CategoryName { get; protected set; }
    }
}
