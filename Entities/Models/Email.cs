using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Email
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress]
        public string User_Email { get; set; }

        [Required(ErrorMessage = "Please enter your email type")]
        public string Email_Type { get; set; }

        [ForeignKey("User_Id")]
        public User_Details User_Details { get; set; }
        public Guid User_Id { get; set; }

        [ForeignKey("RefTerm_Id")]
        public RefTerm RefTerm { get; set; }
        public Guid RefTerm_Id { get; set; }
    }
}
