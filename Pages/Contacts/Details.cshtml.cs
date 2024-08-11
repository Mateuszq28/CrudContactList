using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrudContactList.Data;
using CrudContactList.Models;

namespace CrudContactList.Pages.Contacts
{
    public class DetailsModel : PageModel
    {
        private readonly CrudContactList.Data.ApplicationDbContext _context;

        public DetailsModel(CrudContactList.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Contact Contact { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact.FirstOrDefaultAsync(m => m.Email == id);
            if (contact == null)
            {
                return NotFound();
            }
            else
            {
                Contact = contact;
            }
            return Page();
        }
    }
}
