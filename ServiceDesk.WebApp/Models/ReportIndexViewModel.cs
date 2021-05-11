namespace ServiceDesk.WebApp.Models
{
    using System.Collections.Generic;

    using ServiceDesk.Domain.Entities;

    public sealed class ReportIndexViewModel
    {
        public ReportIndexViewModel(IEnumerable<Report> reports, int totalPages, SortType sort)
        {
            Reports = reports;
            TotalPages = totalPages;

            StatutsSort = sort == SortType.StatusDesc ? SortType.StatusAsc : SortType.StatusDesc;
            NameSort = sort == SortType.NameDesc ? SortType.NameAsc : SortType.NameDesc;
            DateSort = sort == SortType.DateDesc ? SortType.DateAsc : SortType.DateDesc;
            CurrentSort = sort;
        }

        public IEnumerable<Report> Reports { get; set; }

        public int TotalPages { get; set; }

        public SortType StatutsSort { get; }

        public SortType NameSort { get; }

        public SortType DateSort { get; }

        public SortType CurrentSort { get; }
    }
}