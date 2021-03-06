﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BD_GIBDD.Models;
using WebBD_GIBDD.Data;

namespace WebBD_GIBDD.Pages.BrandAutos
{
    public class CreateModel : PageModel
    {
        private readonly WebBD_GIBDD.Data.WebBD_GIBDDContext _context;

        public CreateModel(WebBD_GIBDD.Data.WebBD_GIBDDContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BD_GIBDD.Models.BrandAuto BrandAuto { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BrandAuto.Add(BrandAuto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
