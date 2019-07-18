
namespace ProjectRider.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Range(1,long.MaxValue)]
        public long Budget { get; set; }
    }
}
