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
    public class CartModel : PageModel
    {
        private readonly KeyToSaftey.DBModels.KeyToSafteyContext _context;

        public CartModel(KeyToSaftey.DBModels.KeyToSafteyContext context)
        {
            _context = context;
        }

        public IList<Addtocart> Addtocart { get; set; }

        public Addtocart Addtocartss { get; set; }
        public Product Product { get; set; }

        public async Task OnGetAsync(int pid, string cmd)
        {
            ViewData["Name"] = HttpContext.Session.GetString("Name");
            if (cmd == "delete")
            {

                Addtocartss = await _context.Addtocarts.FirstOrDefaultAsync(m => m.Pid == pid);
                _context.Addtocarts.Remove(Addtocartss);
                await _context.SaveChangesAsync();
            }

            Addtocart = await _context.Addtocarts.Where(x=>x.Mobile == HttpContext.Session.GetString("Mobile")).ToListAsync();

        }
        public async Task OnPostAsync(int pid, string cmd)
        {
           
            if (cmd == "updadte")
            {
                
            }
            Addtocart = await _context.Addtocarts.ToListAsync();
        }
    }
}
