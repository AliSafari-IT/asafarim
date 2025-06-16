using System;
using System.Collections.Generic;
using ASafariM.Domain.Common;

namespace ASafariM.Domain.Entities
{
    public class Initiative : BaseEntity
    {
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<string> TeamMembers { get; set; } = new List<string>();
        public List<string> GoalItems { get; set; } = new List<string>();

        public Initiative(
            string name,
            DateTime? startDate = null,
            DateTime? endDate = null,
            List<string>? teamMembers = null,
            List<string>? goalItems = null
        )
        {
            Name = name ?? throw new ArgumentNullException(nameof(name), "Name cannot be null.");
            StartDate = startDate;
            EndDate = endDate;
            TeamMembers = teamMembers ?? new List<string>();
            GoalItems = goalItems ?? new List<string>();
        }

        public int GetInitiativeDurationInDays()
        {
            return (EndDate.HasValue && StartDate.HasValue)
                ? (EndDate.Value - StartDate.Value).Days
                : 0;
        }

        public void AddTeamMember(string teamMember)
        {
            if (string.IsNullOrWhiteSpace(teamMember))
                throw new ArgumentException(
                    "Team member cannot be null or empty.",
                    nameof(teamMember)
                );

            TeamMembers.Add(teamMember);
        }

        public void RemoveTeamMember(string teamMember)
        {
            if (string.IsNullOrWhiteSpace(teamMember))
                throw new ArgumentException(
                    "Team member cannot be null or empty.",
                    nameof(teamMember)
                );

            TeamMembers.Remove(teamMember);
        }

        public void AddGoalItem(string goalItem)
        {
            if (string.IsNullOrWhiteSpace(goalItem))
                throw new ArgumentException("Goal item cannot be null or empty.", nameof(goalItem));

            GoalItems.Add(goalItem);
        }

        public void RemoveGoalItem(string goalItem)
        {
            if (string.IsNullOrWhiteSpace(goalItem))
                throw new ArgumentException("Goal item cannot be null or empty.", nameof(goalItem));

            GoalItems.Remove(goalItem);
        }

        public void DisplayInitiativeDetails()
        {
            Console.WriteLine($"Initiative ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine(
                $"Start Date: {(StartDate.HasValue ? StartDate.Value.ToShortDateString() : "N/A")}"
            );
            Console.WriteLine(
                $"End Date: {(EndDate.HasValue ? EndDate.Value.ToShortDateString() : "N/A")}"
            );

            Console.WriteLine("Team Members:");
            foreach (var member in TeamMembers)
            {
                Console.WriteLine($"- {member}");
            }

            Console.WriteLine("Goal Items:");
            foreach (var goalItem in GoalItems)
            {
                Console.WriteLine($"- {goalItem}");
            }
        }
    }
}
