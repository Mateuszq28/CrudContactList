using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrudContactList.Data;
using CrudContactList.Models;

namespace CrudContactList.Pages.Subcategories
{
    public class DetailsModel : PageModel
    {
        private readonly CrudContactList.Data.ApplicationDbContext _context;

        public DetailsModel(CrudContactList.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Subcategory Subcategory { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subcategory = await _context.Subcategory.FirstOrDefaultAsync(m => m.Id == id);
            if (subcategory == null)
            {
                return NotFound();
            }
            else
            {
                Subcategory = subcategory;
            }
            return Page();
        }
    }
}
