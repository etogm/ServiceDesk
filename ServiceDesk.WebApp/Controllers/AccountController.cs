namespace ServiceDesk.WebApp.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class AccountController : Controller
    {
        public IActionResult AccessDenied() => View();
    }
}
