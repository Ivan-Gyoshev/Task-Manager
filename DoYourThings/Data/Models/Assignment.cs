namespace DoYourThings.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using DoYourThings.Data.Models.Enums;

    using static DoYourThings.Data.Common.DataConstants;

    public class Assignment
    {
        [Required]
        public string Id { get; set; }

        [Required]
        [MaxLength(AssignmentTitleMaxLength)]
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public bool IsCompleted { get; set; } = false;

        public AssignmentType Type { get; set; }

        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        [Required]
        public string CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
