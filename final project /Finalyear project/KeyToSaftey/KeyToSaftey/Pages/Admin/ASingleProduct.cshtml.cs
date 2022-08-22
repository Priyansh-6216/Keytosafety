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
    public class ASingleProductModel : PageModel
    {
        private readonly KeyToSaftey.DBModels.KeyToSafteyContext _context;

        public ASingleProductModel(KeyToSaftey.DBModels.KeyToSafteyContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Product Product { get; set; }

        public IEnumerable<Image> Image { get; set; }


        public async Task<IActionResult> OnPostAsync(string qty)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var cart = new Addtocart
            {
                Pid = Product.Pid,
                Pname = Product.Pname,
                Mobile = HttpContext.Session.GetString("Mobile"),
                Quantity = qty,
                Price = (Product.Pprice * Convert.ToDecimal(qty)),
                Pprice=Product.Pprice
            };




            _context.Addtocarts.Add(cart);
            await _context.SaveChangesAsync();
            return RedirectToPage("./cart");
        }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            ViewData["Name"] = HttpContext.Session.GetString("Name");
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Products.FirstOrDefaultAsync(m => m.Pid == id);

            Image =  _context.Images.Where(m => m.Pid == id).ToList();

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }


    }
}
