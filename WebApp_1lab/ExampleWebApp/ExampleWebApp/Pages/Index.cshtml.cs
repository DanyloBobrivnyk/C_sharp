using ExampleWebApp.Context;
using ExampleWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly DbEntities db;
        private readonly ILogger<IndexModel> logger;
        private readonly PeopleRepository repository;

        public List<Person> People => repository.People;
        public List<CategoryEntity> Categories { get; protected set; }

        [BindProperty]
        public Person Person { get; set; }

        public IndexModel(DbEntities db, ILogger<IndexModel> logger, PeopleRepository repository)
        {
            this.db = db;
            this.logger = logger;
            this.repository = repository;
        }

        public void OnGet(long? id)
        {
            if (id == null)
            {
                Categories = db.Categories.ToList();
                return;
            }
            Categories = db.Categories.Where(w => w.Id == id).ToList();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            repository.AddPerson(Person);
            return Page();
        }
    }
}