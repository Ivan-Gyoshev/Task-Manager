﻿namespace DoYourThings.DTOs.Assignments
{
    using System;

    using DoYourThings.Data.Models.Enums;

    public class AssignmentsDisplayDTO
    {
        public string Title { get; set; }

        public string Date { get; set; }

        public AssignmentType Type { get; set; }
    }
}
