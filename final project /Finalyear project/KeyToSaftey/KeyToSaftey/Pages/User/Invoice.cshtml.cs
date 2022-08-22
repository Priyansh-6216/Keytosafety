using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KeyToSaftey.DBModels;
using Microsoft.AspNetCore.Http;

namespace KeyToSaftey.Pages.User
{
    public class InvoiceModel : PageModel
    {
        private readonly KeyToSaftey.DBModels.KeyToSafteyContext _context;

        public InvoiceModel(KeyToSaftey.DBModels.KeyToSafteyContext context)
        {
            _context = context;
        }

        public IList<Addtocart> Addtocart { get;set; }
        public IList<Ordermaster> Ordermaster { get; set; }
        public IList<BillingAdd> BillingAdd { get; set; }
        public IList<Signup> Signup { get; set; }

         
        public async Task OnGetAsync()
        {
            ViewData["Name"] = HttpContext.Session.GetString("Name");
            Addtocart = await _context.Addtocarts.Where(x => x.Mobile == HttpContext.Session.GetString("Mobile")).ToListAsync();
            Ordermaster = _context.Ordermasters.ToList();
            BillingAdd = _context.BillingAdds.ToList();
            Signup = _context.Signups.ToList();
        }


    }
}
