
namespace SocialNetwork.Domain.Entities.Models.Base
{
    public class PersonInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EMailAdress { get; set; }
        public int Password { get; set; }

    }
}
