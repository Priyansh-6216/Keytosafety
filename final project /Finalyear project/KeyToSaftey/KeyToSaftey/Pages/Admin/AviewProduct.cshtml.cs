using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KeyToSaftey.DBModels;
using Microsoft.AspNetCore.Http;

namespace KeyToSaftey.Pages.Admin
{
    public class AviewProductModel : PageModel
    {
        private readonly KeyToSaftey.DBModels.KeyToSafteyContext _context;

        public AviewProductModel(KeyToSaftey.DBModels.KeyToSafteyContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get; set; }

        public async Task OnGetAsync()
        {
            //int? idd = Convert.ToInt32(HttpContext.Session.GetString("Id"));

            //if (idd == 0)
            //{
            //    return RedirectToPage("../User/Login");
            //}

            ViewData["Name"] = HttpContext.Session.GetString("Name");
            Product = await _context.Products.ToListAsync();
        }
        public IActionResult OnPost()
        {
            return RedirectToPage("../Admin/AddProduct");
        }
    }
}
