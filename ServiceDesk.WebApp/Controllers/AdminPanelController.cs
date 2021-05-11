namespace ServiceDesk.WebApp.Controllers
{
    using System;
    using System.Linq;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    using ServiceDesk.Domain.Entities;
    using ServiceDesk.Domain.Repositories;

    [Authorize(Roles = "Administrator")]
    public class AdminPanelController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly DataManager dataManager;

        public AdminPanelController(UserManager<IdentityUser> userManager, DataManager dataManager)
        {
            this.userManager = userManager;
            this.dataManager = dataManager;
        }

        [HttpGet]
        public IActionResult Index() => View();

        [HttpGet]
        public IActionResult GenerateReports()
        {
            Random random = new Random();

            for (int i = 0; i < 100; i++)
                dataManager.Reports.Create(new Report()
                {
                    Date = DateTime.Now,
                    FullName = UppercaseFirst(RandomString(6)) + ' ' + UppercaseFirst(RandomString(9)),
                    Phone = RandomNum(10),
                    Status = (Report.StatusType)random.Next(0, 3),
                    Text = RandomString(255),
                    Operator = userManager.Users.First()
                });

            return RedirectToAction("Index", "Report");
        }

        [HttpGet]
        public IActionResult DeleteAllReports()
        {
            var reports = dataManager.Reports.GetReports().ToList();

            foreach (var report in reports) dataManager.Reports.DeleteById(report.Id);

            return RedirectToAction("Index", "Report");
        }
        
        private static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "abcdefghijklmn opqrstuvwxyz";

            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private static string RandomNum(int length)
        {
            Random random = new Random();
            const string chars = "0123456789";

            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private static string UppercaseFirst(string s) =>
            string.IsNullOrEmpty(s) ? string.Empty : char.ToUpper(s[0]) + s.Substring(1);
    }
}
