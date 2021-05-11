namespace ServiceDesk.WebApp.Controllers
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    using ServiceDesk.Domain.Entities;
    using ServiceDesk.Domain.Repositories;
    using ServiceDesk.WebApp.Models;

    [Authorize]
    public sealed class ReportController : Controller
    {
        private readonly DataManager dataManager;

        private readonly UserManager<IdentityUser> userManager;

        public ReportController(DataManager dataManager, UserManager<IdentityUser> userManager)
        {
            this.dataManager = dataManager;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index(SortType sort, int page = 1)
        {
            const int pageSize = 15;

            var reports = dataManager.Reports.GetReports();
            var reportSort = OrderedReport(reports, sort)
                                            .Include(r => r.Operator)
                                            .Skip((page - 1) * pageSize)
                                            .Take(pageSize);

            return View(new ReportIndexViewModel(
                                reportSort,
                                (int)Math.Ceiling((decimal)reports.Count() / pageSize),
                                sort));
        }

        [HttpGet("{controller}/{id}")]
        public async Task<IActionResult> Index(string id)
        {
            var report = dataManager.Reports.GetReportById(id);
            var user = await userManager.GetUserAsync(User);

            if (report.Operator != user) return Unauthorized();

            if (report != null)
                return View("Report", dataManager.Reports.GetReportById(id));

            return NotFound();
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(ReportViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var report = new Report
            {
                Date = DateTime.Now,
                FullName = model.FullName,
                Phone = model.Phone,
                Status = Report.StatusType.Registered,
                Text = model.Text,
                Operator = await userManager.GetUserAsync(User)
            };

            dataManager.Reports.Create(report);

            return RedirectToAction("Index", "Report");
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public IActionResult Delete(string id)
        {
            dataManager.Reports.DeleteById(id);

            return RedirectToAction("Index", "Report");
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public IActionResult Edit(string id) => throw new NotImplementedException();

        private IOrderedQueryable<Report> OrderedReport(IQueryable<Report> reports, SortType sortType)
        {
            switch (sortType)
            {
                case SortType.StatusAsc:
                    return reports.OrderBy(r => r.Status);
                case SortType.StatusDesc:
                    return reports.OrderByDescending(r => r.Status);
                case SortType.NameAsc:
                    return reports.OrderBy(r => r.FullName);
                case SortType.NameDesc:
                    return reports.OrderByDescending(r => r.FullName);
                case SortType.DateAsc:
                    return reports.OrderBy(r => r.Date);
                case SortType.DateDesc:
                    return reports.OrderByDescending(r => r.Date);
                default:
                    throw new ArgumentOutOfRangeException(nameof(sortType), sortType, null);
            }
        }
    }
}
