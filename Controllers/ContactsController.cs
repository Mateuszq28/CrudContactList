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


        // PoST: Contacts/ShowSearchResults
        public async Task<IActionResult> ShowSearchResults(string SearchPhrase)
        {
            return View();
        }
    }
}
