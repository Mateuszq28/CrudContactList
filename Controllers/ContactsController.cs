using Microsoft.AspNetCore.Mvc;

namespace CrudContactList.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET: Contacts/ShowSearchForm
        public async Task<IActionResult> ShowSearchForm()
        {
            return View();
        }
    }
}
