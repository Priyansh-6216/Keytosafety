using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using HtmlAgilityPack;
using KeyToSaftey.DBModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace KeyToSaftey.Pages.User
{
    public class webscrappingModel : PageModel
    {
        private readonly KeyToSaftey.DBModels.KeyToSafteyContext _context;

        public webscrappingModel(KeyToSaftey.DBModels.KeyToSafteyContext context)
        {
            _context = context;
        }

        [BindProperty]
        
        public List<Pinfo> products { get; set; }

        public async Task<IActionResult> OnGetAsync(String id)
        {
            ViewData["Name"] = HttpContext.Session.GetString("Name");
           
            products = _context.Pinfos.ToList();
            


            if (products == null)
            {
                return NotFound();
            }
            string pname = id;
            string page = "https://www.flipkart.com/search?q=" + pname + "&otracker=search&otracker1=search&marketplace=FLIPKART&as-show=off&as=off";

            var web = new HtmlWeb();
            var doc = web.Load(page);

            var SubCategories = doc.DocumentNode.SelectNodes("//*[@class = '_13oc-S']");
            products = new List<Pinfo>();


            foreach (var sc in SubCategories)
            {
                try
                {

                    var name = HttpUtility.HtmlDecode(sc.SelectSingleNode(".//*[@class = 's1Q9rs']").InnerText);
                    var price = HttpUtility.HtmlDecode(sc.SelectSingleNode(".//*[@class = '_30jeq3']").InnerText);
                    var rating = HttpUtility.HtmlDecode(sc.SelectSingleNode(".//*[@class = '_3LWZlK']").InnerText);
                    var img = HttpUtility.HtmlDecode(sc.SelectSingleNode(".//*[@class = 'CXW8mj']").InnerHtml).Replace(@"\", "");
                    var link = page;


                    Pinfo p = new Pinfo()
                    {
                        Name = name,
                        Price = price,
                        Rating = rating,
                        Img = img,
                        Link = link
                    };

                    products.Add(p);
                }
                catch
                {

                }
            }
            return Page();

        }

    }
}
