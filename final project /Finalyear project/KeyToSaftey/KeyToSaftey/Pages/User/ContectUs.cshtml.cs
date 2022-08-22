using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KeyToSaftey.DBModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KeyToSaftey.Pages.User
{
    public class ContectUsModel : PageModel
    {
        private readonly KeyToSaftey.DBModels.KeyToSafteyContext _context;

        public ContectUsModel(KeyToSaftey.DBModels.KeyToSafteyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["Name"] = HttpContext.Session.GetString("Name");
            return Page();
        }
        [BindProperty]
        public Feedback Feedback { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Feedbacks.Add(Feedback);
            await _context.SaveChangesAsync();

           
            return RedirectToPage("./ContectUs");
        }
    }
}

