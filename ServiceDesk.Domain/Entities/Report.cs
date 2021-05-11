namespace ServiceDesk.Domain.Entities
{
    using System;

    using Microsoft.AspNetCore.Identity;

    public class Report
    {
        public Report() => Id = Guid.NewGuid().ToString();

        public enum StatusType
        {
            Registered,
            Executed,
            NotExecuted
        }

        public string Id { get; set; }

        public string FullName { get; set; }

        public string Phone { get; set; }

        public string Text { get; set; }

        public DateTime Date { get; set; }

        public StatusType Status { get; set; }

        public IdentityUser Operator { get; set; }
    }
}