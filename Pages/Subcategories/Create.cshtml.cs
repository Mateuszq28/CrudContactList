using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CrudContactList.Data;
using CrudContactList.Models;

namespace CrudContactList.Pages.Subcategories
{
    public class CreateModel : PageModel
    {
        private readonly CrudContactList.Data.ApplicationDbContext _context;

        public CreateModel(CrudContactList.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Subcategory Subcategory { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Subcategory.Add(Subcategory);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
