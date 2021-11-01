namespace DoYourThings.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using DoYourThings.Data;
    using DoYourThings.Data.Models;
    using DoYourThings.DTOs.Assignments;
    using DoYourThings.Services.Assignments;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class AssignmentsController : ControllerBase
    {
        private readonly IAssignmentsService assignmentsService;
        private readonly ApplicationDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;

        public AssignmentsController(IAssignmentsService assignmentsService, ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            this.assignmentsService = assignmentsService;
            this.dbContext = dbContext;
            this.userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AssignmentInputDto assignment)
        {
            if (!this.dbContext.Categories.Any(c => c.Id != assignment.CategoryId))
            {
                this.ModelState.AddModelError(nameof(assignment.CategoryId), "This category does not exist.");
            }

            var result = await this.assignmentsService.CreateAssignmentAsync(
                assignment.Id,
                assignment.Title,
                assignment.Date,
                assignment.Type,
                assignment.CategoryId,
                assignment.UserId);

            if (result != null)
            {
                return this.StatusCode(201);
            }

            return this.BadRequest();
        }
    }
}
