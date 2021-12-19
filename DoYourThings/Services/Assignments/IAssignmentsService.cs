namespace DoYourThings.Services.Assignments
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using DoYourThings.Data.Models;
    using DoYourThings.Data.Models.Enums;
    using DoYourThings.DTOs.Assignments;

    public interface IAssignmentsService
    {
        Task<string> CreateAssignmentAsync(string id, string title, DateTime date, AssignmentType type, string categoryId, string userId);

        IEnumerable<AssignmentsDisplayDTO> GetAllDailyAssignments();

        Task<bool> CompleteAssignmentAsync(string id);

        Task<bool> DeleteAssignmentAsync(string id);
    }
}
