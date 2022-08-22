using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KeyToSaftey.DBModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace KeyToSaftey.Pages.User
{
    public class AddressModel : PageModel
    {
        private readonly KeyToSaftey.DBModels.KeyToSafteyContext _context;

        public AddressModel(KeyToSaftey.DBModels.KeyToSafteyContext context)
        {
            _context = context;
        }

        public IList<Addtocart> Addtocart { get; set; }

        public IActionResult OnGet()
        {
            int? idd = Convert.ToInt32(HttpContext.Session.GetString("Id"));

            if (idd == 0)
            {
                return RedirectToPage("../User/Login");
            }
            ViewData["Name"] = HttpContext.Session.GetString("Name");
            Addtocart =  _context.Addtocarts.ToList();
            return Page();
        }
       

        [BindProperty]
        public Ordermaster Ordermaster { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
           
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Ordermaster.UserMobile = HttpContext.Session.GetString("Mobile");
            Ordermaster.Status = "In Process";
           

            _context.Ordermasters.Add(Ordermaster);
            await _context.SaveChangesAsync();

            return RedirectToPage("BillingAdd");
        }
    }
}
