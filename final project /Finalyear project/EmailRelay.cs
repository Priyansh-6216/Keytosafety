using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

/// <summary>
/// Summary description for EmailRelay
/// </summary>
public class EmailRelay
{


    public string smtpServer;
    public string userName;
    public string password;


    public EmailRelay()
    {
        smtpServer = "";
        userName = "";
        password = "";
    }

    public static bool ServerCertificateValidationCallback(object sender, System.Security.Cryptography.X509Certificates.X509Certificate cert, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
    {
        return sslPolicyErrors == System.Net.Security.SslPolicyErrors.None;
    }
    public bool SendMail(string toAddress, string subject, string body,bool useSSL)
    {

        MailMessage mm = new MailMessage();
        SmtpClient smtp = new SmtpClient();
        MailAddress emailFrom = new MailAddress("@gebmail.com", "");
        System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();

        try
        {
            NetworkCred.UserName = userName;
            NetworkCred.Password = password;
            mm.To.Add(new MailAddress(toAddress));
            mm.From = emailFrom;
            mm.Subject = subject;
            mm.Body = body;
            mm.IsBodyHtml = true;

            ServicePointManager.ServerCertificateValidationCallback =
    delegate (object s, X509Certificate certificate,
             X509Chain chain, SslPolicyErrors sslPolicyErrors)
    { return true; };

            smtp.Host = smtpServer;
            smtp.EnableSsl = useSSL;
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = NetworkCred;
            smtp.Port = 10025;
            smtp.Send(mm);

        }
        catch (Exception ex)
        {
            return false;
        }

        return true;

    }

}