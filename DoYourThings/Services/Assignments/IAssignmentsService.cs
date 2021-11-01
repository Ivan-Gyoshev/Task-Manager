namespace DoYourThings.Services.Assignments
{
    using System;
    using System.Threading.Tasks;

    using DoYourThings.Data.Models.Enums;

    public interface IAssignmentsService
    {
        Task<string> CreateAssignmentAsync(string id, string title, DateTime date, AssignmentType type, string categoryId, string userId);
    }
}
