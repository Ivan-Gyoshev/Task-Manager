namespace DoYourThings.DTOs.Assignments
{
    using System;

    using DoYourThings.Data.Models.Enums;

    public class AssignmentsDisplayDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Date { get; set; }

        public string UserId { get; set; }

        public AssignmentType Type { get; set; }
    }
}
