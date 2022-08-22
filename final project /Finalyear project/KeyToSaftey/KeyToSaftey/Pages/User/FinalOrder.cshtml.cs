using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KeyToSaftey.DBModels;
using Microsoft.AspNetCore.Http;
using AstroBasic.PayTM.Library;

namespace KeyToSaftey.Pages.User
{
    public class FinalOrderModel : PageModel
    {
        private readonly KeyToSaftey.DBModels.KeyToSafteyContext _context;

        public FinalOrderModel(KeyToSaftey.DBModels.KeyToSafteyContext context)
        {
            _context = context;
        }

        public IList<Addtocart> Addtocart { get;set; }

        public async Task<IActionResult> OnGetAsync()
        {

            int? idd = Convert.ToInt32(HttpContext.Session.GetString("Id"));

            if (idd == 0)
            {
                return RedirectToPage("../User/Login");
            }

            ViewData["Name"] = HttpContext.Session.GetString("Name");
            Addtocart = await _context.Addtocarts.Where(x => x.Mobile == HttpContext.Session.GetString("Mobile")).ToListAsync();
            return Page();

        }

        public ActionResult OnPost()
        {
            Addtocart =  _context.Addtocarts.Where(x => x.Mobile == HttpContext.Session.GetString("Mobile")).ToList();
            string orderid = "D" + DateTime.Now.Ticks.ToString();
            Dictionary<String, String> paytmParams = new Dictionary<String, String>();

            /* Find your MID in your Paytm Dashboard at https://dashboard.paytm.com/next/apikeys */
            paytmParams.Add("MID", "EYMJzM00601019662255");

            /* Find your WEBSITE in your Paytm Dashboard at https://dashboard.paytm.com/next/apikeys */
            paytmParams.Add("WEBSITE", "WEBSTAGING");

            /* Find your INDUSTRY_TYPE_ID in your Paytm Dashboard at https://dashboard.paytm.com/next/apikeys */
            paytmParams.Add("INDUSTRY_TYPE_ID", "Retail");

            /* WEB for website and WAP for Mobile-websites or App */
            paytmParams.Add("CHANNEL_ID", "WEB");

            /* Enter your unique order id */
            paytmParams.Add("ORDER_ID", orderid);

            /* unique id that belongs to your customer */
            paytmParams.Add("CUST_ID", HttpContext.Session.GetString("Mobile"));

            /* customer's mobile number */
            paytmParams.Add("MOBILE_NO", HttpContext.Session.GetString("Mobile"));

            /* customer's email */
            paytmParams.Add("EMAIL", HttpContext.Session.GetString("Email"));

            /**
            * Amount in INR that is payble by customer
            * this should be numeric with optionally having two decimal points
*/
            paytmParams.Add("TXN_AMOUNT", Addtocart.Sum(p=>p.Price).ToString());

            /* on completion of transaction, we will send you the response on this URL */
            paytmParams.Add("CALLBACK_URL", "http://localhost:62112/User/Invoice");

            /**
            * Generate checksum for parameters we have
            * You can get Checksum DLL from https://developer.paytm.com/docs/checksum/
            * Find your Merchant Key in your Paytm Dashboard at https://dashboard.paytm.com/next/apikeys 
*/
            String checksum = CheckSum.generateCheckSum("litW_Jyf0rRAtvpo", paytmParams);

            /* for Staging */
            String url = "https://securegw-stage.paytm.in/order/process";

            /* for Production */
            // String url = "https://securegw.paytm.in/order/process";

            /* Prepare HTML Form and Submit to Paytm */
            String outputHtml = "";
            outputHtml += "<html>";
            outputHtml += "<head>";
            outputHtml += "<title>Merchant Checkout Page</title>";
            outputHtml += "</head>";
            outputHtml += "<body>";
            outputHtml += "<center><h1>Please do not refresh this page...</h1></center>";
            outputHtml += "<form method='post' action='" + url + "' name='paytm_form'>";
            foreach (string key in paytmParams.Keys)
            {
                outputHtml += "<input type='hidden' name='" + key + "' value='" + paytmParams[key] + "'>";
            }
            outputHtml += "<input type='hidden' name='CHECKSUMHASH' value='" + checksum + "'>";
            outputHtml += "</form>";
            outputHtml += "<script type='text/javascript'>";
            outputHtml += "document.paytm_form.submit();";
            outputHtml += "</script>";
            outputHtml += "</body>";
            outputHtml += "</html>";
            HttpContext.Session.SetString("pay", outputHtml.ToString());
            return RedirectToPage("Payment");
        }

        }
}
