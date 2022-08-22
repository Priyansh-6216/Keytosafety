using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KeyToSaftey.DBModels;

namespace KeyToSaftey.Pages.User
{
    public class SignupModel : PageModel
    {
        private readonly KeyToSaftey.DBModels.KeyToSafteyContext _context;

        public SignupModel(KeyToSaftey.DBModels.KeyToSafteyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Signup Signup { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Signups.Add(Signup);
            await _context.SaveChangesAsync();

            ViewData["Name"] = Signup.FullName;
            return RedirectToPage("./Index");
        }
    }
}

