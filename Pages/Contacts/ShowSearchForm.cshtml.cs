using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CrudContactList.Data;
using CrudContactList.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudContactList.Pages.Contacts
{
    public class ShowSearchFormModel : PageModel
    {
        private readonly CrudContactList.Data.ApplicationDbContext _context;

        public ShowSearchFormModel(CrudContactList.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Contact Contact { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        /*
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Contact.Add(Contact);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        */

        // PoST: Contacts/ShowSearchResults
        public async Task<IActionResult> ShowSearchResults(string SearchPhrase)
        {
            // Console.WriteLine won't show in the output. But using red debuging dots shows, that this function is never called up.
            Console.WriteLine("cont controller ShowSearchResults");
            await _context.Contact.Where(j => j.Name.Contains(SearchPhrase)).ToListAsync();
            return Page();
        }
    }
}
