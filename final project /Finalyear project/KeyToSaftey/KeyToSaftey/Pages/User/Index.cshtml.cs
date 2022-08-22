using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KeyToSaftey.DBModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace KetToSaftey.Pages.User
{
    public class Index1Model : PageModel
    {
        private KeyToSafteyContext _context;

        public Index1Model(KeyToSaftey.DBModels.KeyToSafteyContext context)
        {
            _context = context;
        }
        public IList<Product> Product { get; set; }

        public async Task OnGetAsync()
        {
            ViewData["Name"]= HttpContext.Session.GetString("Name");

            Product = await _context.Products.ToListAsync();
        }
    }
}
