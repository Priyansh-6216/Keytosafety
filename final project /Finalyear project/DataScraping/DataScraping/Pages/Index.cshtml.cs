using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using DataScraping.DBmodel;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DataScraping.Pages
{
    public class IndexModel : PageModel
    {
     
        public IActionResult OnGet()
        {
            Things = new List<Pinfo>
                {
                    new Pinfo()
                                {
                                   name = "", price = "", rating = "", img = "", link = ""
                                }
                };

            return Page();
            
        }
        public List<Pinfo> products { get; set; }
        public IActionResult OnPost(string srh)
        {
            string pname = srh; 
            string page = "https://www.flipkart.com/search?q="+pname+"&otracker=search&otracker1=search&marketplace=FLIPKART&as-show=off&as=off&page=1";
           
            var web = new HtmlWeb();
            var doc = web.Load(page);

             var SubCategories = doc.DocumentNode.SelectNodes("//*[@class = '_13oc-S']");
            products = new List<Pinfo>();


            foreach (var sc in SubCategories)
                {
                
                var name = HttpUtility.HtmlDecode(sc.SelectSingleNode(".//*[@class = 's1Q9rs']").InnerText);
                var price = HttpUtility.HtmlDecode(sc.SelectSingleNode(".//*[@class = '_30jeq3']").InnerText);
                var rating = HttpUtility.HtmlDecode(sc.SelectSingleNode(".//*[@class = '_3LWZlK']").InnerText);
                var img = HttpUtility.HtmlDecode(sc.SelectSingleNode(".//*[@class = 'CXW8mj']").InnerHtml).Replace(@"\","");
                var link = page;
               

                Pinfo p = new Pinfo()
                {
                    name = name,
                    price = price,
                    rating = rating,
                    img = img,
                    link = link
                };

                products.Add(p);
            }
            
            return Page();
        }
            //}

            
        }
    }

