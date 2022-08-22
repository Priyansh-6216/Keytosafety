using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KeyToSaftey.Pages.User
{
    public class AboutusModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Name"] = HttpContext.Session.GetString("Name");
        }
    }
}
