﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using pizza_mama.Data;
using pizza_mama.Models;

namespace pizza_mama.Pages.Admin.Pizzas
{
    public class CreateModel : PageModel
    {
        private readonly pizza_mama.Data.DataContex _context;

        public CreateModel(pizza_mama.Data.DataContex context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Pizza Pizza { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Pizzas.Add(Pizza);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}