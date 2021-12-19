namespace DoYourThings.Controllers
{
    using System.Threading.Tasks;

    using DoYourThings.Data;
    using DoYourThings.DTOs.Assignments;
    using DoYourThings.Services.Assignments;
    using DoYourThings.Services.Categories;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class AssignmentsController : ControllerBase
    {
        private readonly IAssignmentsService assignmentsService;
        private readonly ICategoriesService categoriesService;

        public AssignmentsController(IAssignmentsService assignmentsService, ICategoriesService categoriesService)
        {
            this.assignmentsService = assignmentsService;
            this.categoriesService = categoriesService;
        }

        [HttpGet]
        public IActionResult GetAllInCompleted()
        {
            var incompletedAssignments = this.assignmentsService.GetAllDailyAssignments();

            return this.Ok(incompletedAssignments);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AssignmentInputDto assignment)
        {
            if (!this.categoriesService.GetById(assignment.CategoryId))
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

        [HttpPut("{id}")]
        public async Task<IActionResult> Complete(string id)
        {
            var result = await this.assignmentsService.CompleteAssignmentAsync(id);

            if (!result)
            {
                return this.BadRequest();
            }

            return this.Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await this.assignmentsService.DeleteAssignmentAsync(id);

            if (!result)
            {
                return this.BadRequest();
            }

            return this.Ok();
        }
    }
}
