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
        Task<int> CreateAssignmentAsync(string title, DateTime date, string categoryId, string userId);

        AssignmentsDisplayDTO GetAssignment(int id);

        IEnumerable<AssignmentsDisplayDTO> GetAllDailyAssignments();

        Task<bool> CompleteAssignmentAsync(int id);

        Task<bool> DeleteAssignmentAsync(int id);
    }
}
