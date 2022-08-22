using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KeyToSaftey.DBModels;
using Microsoft.AspNetCore.Http;

namespace KeyToSaftey.Pages.User
{
    public class BillingAddModel : PageModel
    {
        private readonly KeyToSaftey.DBModels.KeyToSafteyContext _context;

        public BillingAddModel(KeyToSaftey.DBModels.KeyToSafteyContext context)
        {
            _context = context;
        }
        public IList<Addtocart> Addtocart { get; set; }

        public Ordermaster Ordermaster { get; set; }

        public IActionResult OnGet()
        {
            Ordermaster= _context.Ordermasters.FirstOrDefault(m => m.UserMobile == HttpContext.Session.GetString("Mobile"));
            ViewData["Name"] = HttpContext.Session.GetString("Name");
            Addtocart = _context.Addtocarts.ToList();
            return Page();
        }

        [BindProperty]
        public BillingAdd BillingAdd { get; set; }
      

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var ordermaster = _context.Ordermasters.FirstOrDefault(m=>m.UserMobile == HttpContext.Session.GetString("Mobile"));
            BillingAdd.Orderid =  Convert.ToInt32( ordermaster.Orderid);
            _context.BillingAdds.Add(BillingAdd);
            await _context.SaveChangesAsync();

            return RedirectToPage("FinalOrder");
        }


    }
}
