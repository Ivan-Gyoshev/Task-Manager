namespace DoYourThings.Services.Assignments
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using DoYourThings.Data;
    using DoYourThings.Data.Models;
    using DoYourThings.Data.Models.Enums;
    using DoYourThings.DTOs.Assignments;

    public class AssignmentsService : IAssignmentsService
    {
        const string dailyId = "3ef199f1-7b07-4815-926a-e89d3b75e82a";

        private readonly ApplicationDbContext dbContext;

        public AssignmentsService(ApplicationDbContext dbContext)
            => this.dbContext = dbContext;

        public async Task<bool> CompleteAssignmentAsync(string id)
        {
            var assignment = this.dbContext.Assignments.FirstOrDefault(a => a.Id == id);

            if (assignment == null)
            {
                return false;
            }

            assignment.IsCompleted = true;
            await this.dbContext.SaveChangesAsync();

            return true;
        }

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

        public async Task<bool> DeleteAssignmentAsync(string id)
        {
            var assignment = this.dbContext.Assignments.FirstOrDefault(a => a.Id == id);

            if (assignment == null)
            {
                return false;
            }

            this.dbContext.Assignments.Remove(assignment);
            await this.dbContext.SaveChangesAsync();

            return true;
        }

        public IEnumerable<AssignmentsDisplayDTO> GetAllDailyAssignments()
            => this.dbContext.Assignments
                .Where(a => a.CategoryId == dailyId && a.IsCompleted == false)
                .Select(a => new AssignmentsDisplayDTO
                {
                    Title = a.Title,
                    Date = a.Date,
                    Type = a.Type,
                })
                .ToList();
    }
}
