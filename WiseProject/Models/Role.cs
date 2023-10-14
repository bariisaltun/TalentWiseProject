using System.ComponentModel.DataAnnotations;

namespace WiseProject.Models
{
    public class Role : IEntity
    {
        [Key]
        public string Id { get; set; }

        
        public string Name { get; set; }

        
    }
}
