using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

public class HomeController : Controller
{
    public IActionResult Index() => View();
    public IActionResult About() => View();
    public IActionResult Skills() => View();
    public IActionResult Projects() => View();
    public IActionResult Contact() => View();
    public IActionResult Experience() => View();

    [HttpPost]
    public IActionResult SendMessage(string Name, string Email,string Subject, string Message)
    {
        //var mail = new MailMessage();
        //mail.To.Add("anjalivasoya12@gmail.com");
        //mail.From = new MailAddress("your-email@gmail.com");
        //mail.Subject = "Portfolio Contact Message";
        //mail.Body = $"Name: {Name}\nEmail: {Email}\nMessage: {Message}";

        //var smtp = new SmtpClient("smtp.gmail.com", 587)
        //{
        //    Credentials = new NetworkCredential("your-email@gmail.com", "your-app-password"),
        //    EnableSsl = true
        //};

        //smtp.Send(mail);

        //ViewBag.Success = "Message Sent Successfully!";
        //return View("Contact");
        return RedirectToAction("Contact");
    }
}
