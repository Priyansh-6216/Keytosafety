using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KeyToSaftey.DBModels;
using Microsoft.AspNetCore.Http;

namespace KeyToSaftey.Pages.User
{
    public class OximeterModel : PageModel
    {
        private readonly KeyToSaftey.DBModels.KeyToSafteyContext _context;

        public OximeterModel(KeyToSaftey.DBModels.KeyToSafteyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Product Product { get; set; }
        public List<Product> Products { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            ViewData["Name"] = HttpContext.Session.GetString("Name");
            Products = await _context.Products.ToListAsync();

            if (Products == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
