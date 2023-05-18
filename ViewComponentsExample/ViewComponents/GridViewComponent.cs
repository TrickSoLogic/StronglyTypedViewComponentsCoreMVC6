using Microsoft.AspNetCore.Mvc;
using StronglyTypedViewComponentsCoreMVC6.Models;

namespace StronglyTypedViewComponentsCoreMVC6.ViewComponents
{
  public class GridViewComponent : ViewComponent
  {
    public async Task<IViewComponentResult> InvokeAsync()
    {
      PersonGridModel personGridModel = new PersonGridModel()
      {
        GridTitle = "Persons List",
        Persons = new List<Person>() {
          new Person() { PersonName = "John", JobTitle = "Manager" },
          new Person() { PersonName = "Jones", JobTitle = "Asst. Manager" },
          new Person() { PersonName = "William", JobTitle = "Clerk" },
        }
      };
      return View("Sample", personGridModel); //invoked a partial view Views/Shared/Components/Grid/Default.cshtml
    }
  }
}
