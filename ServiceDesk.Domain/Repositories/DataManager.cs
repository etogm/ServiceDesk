namespace ServiceDesk.Domain.Repositories
{
    using ServiceDesk.Domain.Repositories.Abstract;

    public class DataManager
    {
        public DataManager(IReportRepository reports) => Reports = reports;

        public IReportRepository Reports { get; }
    }
}