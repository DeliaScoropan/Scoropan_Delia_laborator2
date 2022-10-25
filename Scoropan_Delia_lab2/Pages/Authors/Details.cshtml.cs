﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Scoropan_Delia_lab2.Data;
using Scoropan_Delia_lab2.Models;

namespace Scoropan_Delia_lab2.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly Scoropan_Delia_lab2.Data.Scoropan_Delia_lab2Context _context;

        public DetailsModel(Scoropan_Delia_lab2.Data.Scoropan_Delia_lab2Context context)
        {
            _context = context;
        }

      public Author Author { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Author == null)
            {
                return NotFound();
            }

            var author = await _context.Author.FirstOrDefaultAsync(m => m.ID == id);
            if (author == null)
            {
                return NotFound();
            }
            else 
            {
                Author = author;
            }
            return Page();
        }
    }
}
