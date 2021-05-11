namespace ServiceDesk.Domain.Repositories.EntityFrameworkCore
{
    using System.Linq;

    using ServiceDesk.Domain.Entities;
    using ServiceDesk.Domain.Repositories.Abstract;

    public class EfReportRepository : IReportRepository
    {
        private readonly ServiceDeskContext ctx;

        public EfReportRepository(ServiceDeskContext ctx) => this.ctx = ctx;

        public Report GetReportById(string key)
        {
            return ctx.Reports.FirstOrDefault(r => r.Id == key);
        }

        public IQueryable<Report> GetReports() => ctx.Reports;

        public void Create(Report entity)
        {
            ctx.Reports.Add(entity);
            ctx.SaveChanges();
        }

        public void DeleteById(string key)
        {
            var report = ctx.Reports.FirstOrDefault(r => r.Id == key);

            if (report == null) return;

            ctx.Reports.Remove(report);
            ctx.SaveChanges();
        }
    }
}