namespace ServiceDesk.Domain.Repositories.Abstract
{
    using System.Linq;

    using ServiceDesk.Domain.Entities;

    public interface IReportRepository
    {
        Report GetReportById(string key);

        IQueryable<Report> GetReports();

        void Create(Report entity);

        void DeleteById(string key);
    }
}