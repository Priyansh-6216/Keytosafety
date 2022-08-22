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
    public class ABlogListModel : PageModel
    {
        private readonly KeyToSaftey.DBModels.KeyToSafteyContext _context;

        public ABlogListModel(KeyToSaftey.DBModels.KeyToSafteyContext context)
        {
            _context = context;
        }

        public IList<Blog> Blog { get;set; }

        public async Task OnGetAsync()
        {
            ViewData["Name"] = HttpContext.Session.GetString("Name");           
            Blog = await _context.Blogs.ToListAsync();
        }
        public IActionResult OnPost()
        {
            return RedirectToPage("../Admin/AddBlog");
        }
    }
}
