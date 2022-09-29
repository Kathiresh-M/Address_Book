using Entities.Models;

namespace Entities.Dto
{
    public class UserForCreatingDto
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string User_Name { get; set; }
        public ICollection<Email> Email { get; set; } = new List<Email>();
        public string Password { get; set; }
        public ICollection<Address> Address { get; set; } = new List<Address>();
        public ICollection<Phone> Phone { get; set; } = new List<Phone>();
    }
}
