using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WiseProject.Models
{
    public class Enrollment : IEntity
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("AspNetUsers")]
        public string UserId { get; set; }
        //public User User { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EnrollmentDate { get; set; }
    }
}
