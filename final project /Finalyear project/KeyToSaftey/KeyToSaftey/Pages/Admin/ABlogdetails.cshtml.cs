using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KeyToSaftey.DBModels;
using Microsoft.AspNetCore.Http;

namespace KeyToSaftey.Pages.Admin
{
    public class ABlogdetailsModel : PageModel
    {
        private readonly KeyToSaftey.DBModels.KeyToSafteyContext _context;

        public ABlogdetailsModel(KeyToSaftey.DBModels.KeyToSafteyContext context)
        {
            _context = context;
        }

        public Blog Blog { get; set; }
        public IList<Blog> Blogs { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            ViewData["Name"] = HttpContext.Session.GetString("Name");
            if (id == null)
            {
                return NotFound();
            }

            Blog = await _context.Blogs.FirstOrDefaultAsync(m => m.Bid == id);
            Blogs = _context.Blogs.Where(m => m.Bid == id).ToList();

            if (Blog == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
