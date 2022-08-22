using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KeyToSaftey.DBModels;
using Microsoft.AspNetCore.Http;

namespace KeyToSaftey.Pages.Admin
{
    public class ASignupModel : PageModel
    {
        private readonly KeyToSaftey.DBModels.KeyToSafteyContext _context;

        public ASignupModel(KeyToSaftey.DBModels.KeyToSafteyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AdminSignup AdminSignup { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost()
        {
            AdminSignup = _context.AdminSignups.FirstOrDefault(k => k.Amobile == AdminSignup.Amobile && k.Apassword == AdminSignup.Apassword);
            if (AdminSignup != null)
            {
                HttpContext.Session.SetString("Id", AdminSignup.Id.ToString());
                HttpContext.Session.SetString("Name", AdminSignup.AfullName);
                HttpContext.Session.SetString("Mobile", AdminSignup.Amobile);
                HttpContext.Session.SetString("Email", AdminSignup.Aemail);
                ViewData["Name"] = AdminSignup.AfullName;
                ViewData["Mobile"] = AdminSignup.Amobile;
                return RedirectToPage("../Admin/AviewProduct");
            }

            ModelState.AddModelError("Error", "Please check mobile no or password");
            return Page();

        }
    }
}
