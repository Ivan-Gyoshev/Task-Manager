namespace DoYourThings.DTOs.Assignments
{
    using System;
    using System.Collections.Generic;

    public class AssignmentInputDto
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string UserId { get; set; }

        public string CategoryId { get; set; }

        public IEnumerable<AssignmentCategoriesDTO> Categories { get; set; }

    }
}
