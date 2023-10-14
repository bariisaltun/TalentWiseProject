using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WiseProject.Models
{
    public class Course : IEntity
    {
        [Key]
        public int Id { get; set; }

        //[ForeignKey("AspNetUsers")]
        public string UserId { get; set; }
        //public User User { get; set; }

        [Required]
        [MaxLength(150)]
        public string Title { get; set; }

        [Required]
        [MaxLength(150)]
        public string Description { get; set; }

        [Required]
        [MaxLength(50)]
        public string Category { get; set; }

        [Required]
       
        public int EnrollmentCount { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public List<Assignment> Assignment { get; set; }
    }
}
