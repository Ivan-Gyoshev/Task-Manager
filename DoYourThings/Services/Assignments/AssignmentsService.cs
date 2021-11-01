namespace DoYourThings.Services.Assignments
{
    using System;
    using System.Threading.Tasks;

    using DoYourThings.Data;
    using DoYourThings.Data.Models;
    using DoYourThings.Data.Models.Enums;

    public class AssignmentsService : IAssignmentsService
    {
        private readonly ApplicationDbContext dbContext;

        public AssignmentsService(ApplicationDbContext dbContext)
            => this.dbContext = dbContext;

        public async Task<string> CreateAssignmentAsync(string id, string title, DateTime date, AssignmentType type, string categoryId, string userId)
        {
            Enum.TryParse(typeof(AssignmentType), type.ToString(), out object typeResult);

            var assignment = new Assignment
            {
                Id = id,
                Title = title,
                Date = date,
                Type = (AssignmentType)typeResult,
                CategoryId = categoryId,
                UserId = userId,
            };

            await this.dbContext.Assignments.AddAsync(assignment);
            await this.dbContext.SaveChangesAsync();

            return assignment.Id;
        }
    }
}
