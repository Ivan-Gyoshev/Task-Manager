namespace DoYourThings.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DoYourThings.Data.Common.DataConstants;

    public class Category
    {
        public Category()
            => this.Assignments = new List<Assignment>();

        [Required]
        public string Id { get; set; }

        [Required]
        [MaxLength(CategoryTitleMaxLength)]
        public string Title { get; set; }

        public ICollection<Assignment> Assignments { get; set; }
    }
}
