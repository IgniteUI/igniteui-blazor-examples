using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Infragistics.Samples
{
    /// <summary>
    /// One row of the team directory. Grid Lite serializes every public property to the browser with
    /// its C# name, so the values the cell templates display are computed here once.
    /// </summary>
    public record TeamMember(
        int Id,
        string FirstName,
        string LastName,
        string Department,
        string EmploymentType,
        int Satisfaction,
        DateOnly Registered,
        bool Active,
        string Location,
        int AvatarTone)
    {
        public string Name => $"{FirstName} {LastName}";

        public string Email => $"{FirstName}.{LastName}@example.com".ToLowerInvariant();

        public string Initials => $"{FirstName[0]}{LastName[0]}";

        // The Registered column's value, so its filter matches what is displayed ("Mar", "2026").
        // events.js sorts it by date, which relies on this exact format.
        public string RegisteredLabel => Registered.ToString("MMM d, yyyy", CultureInfo.InvariantCulture);

        // A copy of Department for a hidden column: the department chips filter on it, so they stay
        // independent of the Department column's own filter in the filter row.
        public string QuickFilterDepartment => Department;
    }

    public record DepartmentOption(string Name, int Count);

    public static class TeamDirectoryData
    {
        public static readonly string[] Departments = { "Engineering", "Finance", "Marketing", "Sales" };

        // The number of avatar color tones in index.css; people cycle through them.
        private const int AvatarToneCount = 6;

        private static readonly (string First, string Last, string Department, string Type, int Satisfaction, string Registered, bool Active, string Location)[] Seed =
        {
            ("Ivy", "Thomas", "Marketing", "Full-time", 1, "2025-10-24", true, "New York, US"),
            ("Alice", "Anderson", "Sales", "Part-time", 1, "2026-03-30", false, "London, UK"),
            ("Ivy", "Williams", "Engineering", "Part-time", 0, "2026-06-03", true, "Berlin, DE"),
            ("Diana", "Johnson", "Marketing", "Full-time", 3, "2026-08-27", true, "Toronto, CA"),
            ("Quinn", "Smith", "Finance", "Contract", 2, "2026-03-11", false, "Sofia, BG"),
            ("John", "Moore", "Engineering", "Full-time", 5, "2025-10-23", true, "Singapore, SG"),
            ("Rachel", "Brown", "Engineering", "Contract", 2, "2026-08-02", true, "London, UK"),
            ("Jane", "Taylor", "Marketing", "Contract", 4, "2025-11-30", false, "New York, US"),
            ("Quinn", "Garcia", "Sales", "Contract", 2, "2026-01-26", true, "Toronto, CA"),
            ("Peter", "Taylor", "Sales", "Full-time", 1, "2026-10-03", true, "Berlin, DE"),
            ("Jane", "Jackson", "Finance", "Full-time", 4, "2026-08-08", false, "New York, US"),
            ("Diana", "Smith", "Marketing", "Part-time", 5, "2026-03-06", true, "Sofia, BG"),
            ("Noah", "Harris", "Sales", "Full-time", 2, "2025-12-13", true, "Singapore, SG"),
            ("Grace", "Wilson", "Finance", "Full-time", 3, "2025-11-23", true, "London, UK"),
            ("Bob", "Taylor", "Marketing", "Part-time", 3, "2025-12-04", false, "Toronto, CA"),
            ("John", "White", "Finance", "Full-time", 3, "2025-10-28", true, "New York, US"),
            ("Charlie", "White", "Sales", "Part-time", 3, "2025-12-23", true, "Berlin, DE"),
            ("Bob", "Thomas", "Finance", "Contract", 4, "2026-03-14", true, "Sofia, BG"),
            ("John", "Jones", "Finance", "Contract", 0, "2026-10-15", false, "London, UK"),
            ("Grace", "Jones", "Engineering", "Full-time", 0, "2026-10-10", true, "Singapore, SG"),
            ("John", "Wilson", "Engineering", "Full-time", 5, "2025-11-28", true, "New York, US"),
            ("Maya", "Patel", "Engineering", "Full-time", 4, "2026-02-17", true, "Singapore, SG"),
            ("Liam", "Nguyen", "Engineering", "Contract", 3, "2026-05-21", true, "Toronto, CA"),
            ("Sofia", "Rossi", "Marketing", "Full-time", 5, "2026-01-09", true, "Berlin, DE"),
            ("Ethan", "Clark", "Sales", "Full-time", 2, "2026-07-14", false, "New York, US"),
            ("Olivia", "Martinez", "Finance", "Part-time", 4, "2026-04-02", true, "London, UK"),
            ("Lucas", "Kim", "Engineering", "Full-time", 3, "2025-12-30", true, "Sofia, BG"),
            ("Amara", "Okafor", "Sales", "Full-time", 5, "2026-06-25", true, "London, UK"),
            ("Mateo", "Lopez", "Marketing", "Contract", 2, "2026-09-18", true, "Toronto, CA"),
            ("Hannah", "Becker", "Finance", "Full-time", 3, "2026-02-03", false, "Berlin, DE"),
            ("Ravi", "Shah", "Engineering", "Part-time", 4, "2026-08-19", true, "Singapore, SG"),
            ("Chloe", "Dubois", "Marketing", "Full-time", 1, "2025-11-07", true, "Sofia, BG"),
            ("Daniel", "Cohen", "Sales", "Contract", 3, "2026-03-22", true, "New York, US"),
            ("Aisha", "Rahman", "Engineering", "Full-time", 5, "2026-05-05", true, "London, UK"),
            ("Tom", "Fischer", "Finance", "Contract", 2, "2026-07-30", false, "Berlin, DE"),
            ("Emma", "Larsen", "Sales", "Part-time", 4, "2026-01-17", true, "Sofia, BG"),
        };

        public static List<TeamMember> CreateMembers()
        {
            return Seed
                .Select((p, index) => new TeamMember(
                    Id: index + 1,
                    FirstName: p.First,
                    LastName: p.Last,
                    Department: p.Department,
                    EmploymentType: p.Type,
                    Satisfaction: p.Satisfaction,
                    Registered: DateOnly.ParseExact(p.Registered, "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    Active: p.Active,
                    Location: p.Location,
                    AvatarTone: index % AvatarToneCount))
                .ToList();
        }

        public static List<DepartmentOption> CreateDepartmentOptions(IReadOnlyCollection<TeamMember> members)
        {
            return Departments
                .Select(department => new DepartmentOption(department, members.Count(m => m.Department == department)))
                .ToList();
        }
    }
}
