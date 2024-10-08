﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly CrudContactList.Data.ApplicationDbContext _context;

        public IndexModel(CrudContactList.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Subcategory> Subcategory { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Subcategory = await _context.Subcategory.ToListAsync();
        }
    }
}
