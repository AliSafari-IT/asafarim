using System;
using ASafariM.Domain.Common;

namespace ASafariM.Domain.Entities
{
    public class Assignment : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public string Assignee { get; set; }
        public string Status { get; set; }

        public Assignment(
            string title,
            string description,
            DateTime? dueDate = null,
            string assignee = "Unassigned",
            string status = "Pending"
        )
        {
            Title =
                title ?? throw new ArgumentNullException(nameof(title), "Title cannot be null.");
            Description =
                description
                ?? throw new ArgumentNullException(
                    nameof(description),
                    "Description cannot be null."
                );
            DueDate = dueDate;
            Assignee = assignee ?? "Unassigned"; // Default value if null
            Status = status ?? "Pending"; // Default value if null
        }

        public bool IsOverdue()
        {
            return DueDate.HasValue && DueDate.Value.Date < DateTime.UtcNow.Date;
        }

        public void UpdateStatus(string status)
        {
            if (string.IsNullOrWhiteSpace(status))
                throw new ArgumentException("Status cannot be null or empty.", nameof(status));

            Status = status;
        }

        public void AssignTo(string user)
        {
            if (string.IsNullOrWhiteSpace(user))
                throw new ArgumentException("Assignee cannot be null or empty.", nameof(user));

            Assignee = user;
        }

        public void DisplayAssignmentDetails()
        {
            Console.WriteLine($"Assignment ID: {Id}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine(
                $"Due Date: {(DueDate.HasValue ? DueDate.Value.ToShortDateString() : "N/A")}"
            );
            Console.WriteLine($"Assignee: {Assignee}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Overdue: {(IsOverdue() ? "Yes" : "No")}");
        }
    }
}
