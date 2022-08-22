using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KeyToSaftey.DBModels;
using Microsoft.AspNetCore.Http;

namespace KeyToSaftey.Pages.Admin
{
    public class BlogUpdateModel : PageModel
    {
        private readonly KeyToSaftey.DBModels.KeyToSafteyContext _context;

        public BlogUpdateModel(KeyToSaftey.DBModels.KeyToSafteyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Blog Blog { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            ViewData["Name"] = HttpContext.Session.GetString("Name");
            if (id == null)
            {
                return NotFound();
            }

            Blog = await _context.Blogs.FirstOrDefaultAsync(m => m.Bid == id);

            if (Blog == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

          //var test = await _context.Blogs.FirstOrDefaultAsync(m => m.Bid ==  Convert.ToInt32( Request.Query["id"]));

            if (!ModelState.IsValid)
            {
                return Page();
            }

           
            _context.Attach(Blog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BlogExists(Blog.Bid))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
          

            return RedirectToPage("./ABlogList");
        }

        private bool BlogExists(int id)
        {
            return _context.Blogs.Any(e => e.Bid == id);
        }
    }
}
