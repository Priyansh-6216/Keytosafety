using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KeyToSaftey.DBModels;
using Microsoft.AspNetCore.Http;
using AstroBasic.PayTM.Library;

namespace KeyToSaftey.Pages.User
{
    public class PaymentModel : PageModel
    {
        private readonly KeyToSaftey.DBModels.KeyToSafteyContext _context;

        public PaymentModel(KeyToSaftey.DBModels.KeyToSafteyContext context)
        {
            _context = context;
        }
        public IList<Addtocart> Addtocarts { get; set; }
        public IActionResult OnGet()
        {
            ViewData["Name"] = HttpContext.Session.GetString("Name");
             ViewData["id"] = HttpContext.Session.GetString("pay");
                return Page();
            
            
        }




      





       
    }
}
