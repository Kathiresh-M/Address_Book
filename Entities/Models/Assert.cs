using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Assert
    {
        [Key]
        public Guid Id { get; set; }
        public string Asserts { get; set; }

        [ForeignKey("User_Id")]
        public User_Details User_Details { get; set; }
        public Guid User_Id { get; set; }
    }
}
