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
    public class SingleProductModel : PageModel
    {
        private readonly KeyToSaftey.DBModels.KeyToSafteyContext _context;

        public SingleProductModel(KeyToSaftey.DBModels.KeyToSafteyContext context)
        {
            _context = context;
        }


        [BindProperty]
        public Product Product { get; set; }
     
        public IEnumerable<Image> Image { get; set; }


        public async Task<IActionResult> OnPostAsync(int pid,string qty)
        {
            int? idd = Convert.ToInt32(HttpContext.Session.GetString("Id"));

            if (idd == 0)
            {
                return RedirectToPage("../User/Login");
            }


            if (!ModelState.IsValid)
            {
                return Page();
            }

            Product = await _context.Products.FirstOrDefaultAsync(m => m.Pid == pid);


            var cart = new Addtocart
            {
                Pid = Product.Pid,
                Pname = Product.Pname,
                Mobile = HttpContext.Session.GetString("Mobile"),
                Quantity = qty,
                Price = (Product.Pprice * Convert.ToDecimal(qty)),
                Pimg=Product.Pimg,
                Pprice=Product.Pprice
            };




            _context.Addtocarts.Add(cart);
            await _context.SaveChangesAsync();
            return RedirectToPage("Cart");
        }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            ViewData["Name"] = HttpContext.Session.GetString("Name");
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Products.FirstOrDefaultAsync(m => m.Pid == id);

            Image = _context.Images.Where(m => m.Pid == id).ToList();

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }


    }
}
