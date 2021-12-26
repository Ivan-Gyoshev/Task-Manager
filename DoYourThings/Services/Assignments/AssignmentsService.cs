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
        private readonly ApplicationDbContext dbContext;

        public AssignmentsService(ApplicationDbContext dbContext)
            => this.dbContext = dbContext;

        public async Task<bool> CompleteAssignmentAsync(int id)
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

        public async Task<int> CreateAssignmentAsync(string title, DateTime date, string categoryId, string userId)
        {
            var assignment = new Assignment
            {
                Title = title,
                Date = date,
                CategoryId = categoryId,
                UserId = userId,
            };

            await this.dbContext.Assignments.AddAsync(assignment);
            await this.dbContext.SaveChangesAsync();

            return assignment.Id;
        }

        public async Task<bool> DeleteAssignmentAsync(int id)
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
                .Where(a => a.IsCompleted == false && a.Date.Date.Equals(DateTime.Now.Date))
                .Select(a => new AssignmentsDisplayDTO
                {
                    Id = a.Id,
                    Title = a.Title,
                    Date = a.Date.ToString("dd-MM-yyyy"),
                    Type = a.Type,
                    UserId = a.UserId,
                })
                .ToList();

        public AssignmentsDisplayDTO GetAssignment(int id)
        => this.dbContext.Assignments
            .Where(a => a.Id == id)
            .Select(a => new AssignmentsDisplayDTO
            {
                Id = a.Id,
                Title = a.Title,
                Date = a.Date.ToString("dd-MM-yyyy"),
                Type = a.Type,
                UserId = a.UserId,
            })
            .FirstOrDefault();
    }
}
