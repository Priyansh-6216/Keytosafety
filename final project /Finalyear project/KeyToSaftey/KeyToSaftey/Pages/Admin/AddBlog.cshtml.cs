using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KeyToSaftey.DBModels;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace KeyToSaftey.Pages.Admin
{
    public class AddBlogModel : PageModel
    {
        private readonly KeyToSaftey.DBModels.KeyToSafteyContext _context;

        public AddBlogModel(KeyToSaftey.DBModels.KeyToSafteyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["Name"] = HttpContext.Session.GetString("Name");
            return Page();
        }

        [BindProperty]
        public Blog Blog { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var file = Request.Form.Files[0];

            if (file.Length > 0)
            {
                using (var stream = new MemoryStream())
                {
                    await file.CopyToAsync(stream);
                    Blog.Bimage = stream.ToArray();
                }
            }
            _context.Blogs.Add(Blog);
            await _context.SaveChangesAsync();
            

            return RedirectToPage("./ABlogList");
        }
    }
}
