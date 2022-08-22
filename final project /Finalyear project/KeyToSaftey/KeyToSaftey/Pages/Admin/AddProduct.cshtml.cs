using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KeyToSaftey.DBModels;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace KeyToSaftey.Pages.Admin
{
    public class AddProductModel : PageModel
    {
        private readonly KeyToSaftey.DBModels.KeyToSafteyContext _context;

        public AddProductModel(KeyToSaftey.DBModels.KeyToSafteyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["Name"] = HttpContext.Session.GetString("Name");
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var file = Request.Form.Files[0];

            if (file.Length > 0)
            {
                using (var stream = new MemoryStream())
                {
                    await file.CopyToAsync(stream);
                    Product.Pimg = stream.ToArray();
                }
            }

            _context.Products.Add(Product);
            await _context.SaveChangesAsync();

            foreach (var file_s in Request.Form.Files)
            {

                if (file_s.Length > 0)
                {
                    using (var stream = new MemoryStream())
                    {
                        await file_s.CopyToAsync(stream);
                        var img = new Image
                        {
                            Pid = Product.Pid,
                            Image1 = stream.ToArray()
                        };

                        _context.Images.Add(img);
                        await _context.SaveChangesAsync();


                    }
                }
            }





            return RedirectToPage("./AviewProduct");
        }
    }
}
