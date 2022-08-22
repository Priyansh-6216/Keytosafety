using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KeyToSaftey.DBModels;
using Microsoft.AspNetCore.Http;
using RestSharp;

namespace KeyToSaftey.Pages.User
{
    public class LoginModel : PageModel
    {
        private readonly KeyToSaftey.DBModels.KeyToSafteyContext _context;

        public LoginModel(KeyToSaftey.DBModels.KeyToSafteyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Signup Signup { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost()
        {

            Signup = _context.Signups.FirstOrDefault(k => k.Mobile == Signup.Mobile && k.Password == Signup.Password);
            if (Signup != null)
            {
                HttpContext.Session.SetString("Id", Signup.Id.ToString());
                HttpContext.Session.SetString("Name", Signup.FullName);
                HttpContext.Session.SetString("Mobile", Signup.Mobile);
                HttpContext.Session.SetString("Email", Signup.Email);
                ViewData["Name"] = Signup.FullName;
                ViewData["Mobile"] = Signup.Mobile;

                //EmailRelay email = new EmailRelay();
                //email.SendMail("janki.170410107090@gmailcom", "Login Successfull", "<b>Hello,</b> <p> Email form Key to Saftey </p>", true);


                //SM Coding
                string sms = "Thank You for Login on Key To Safety";
                string mobileno ="7984428233";
                string api = "KtL3PRrNz84CSysjlb6u5YaUVieEokqTdFZv1fnIwQ9xAD0Hp7hTA2s1zPY9DuBCkXv3xMceGQKEtLWl";
                var client = new RestClient(" https://www.fast2sms.com/dev/bulkV2?authorization=" + api + "&route=q&message=" + sms + "&language=english&flash=0&numbers=" + mobileno + "");
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                //
                return RedirectToPage("../User/Index");


            }

            ModelState.AddModelError("Error", "Please check mobile no or password");
            return Page();
        }
    }
}
