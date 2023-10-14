using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WiseProject.Models
{
    public class UserRole : IEntity
    {
        [Key]
        public int Id { get; set; }

        
        public int UserId { get; set; }
        //public User User { get; set; }

        
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
