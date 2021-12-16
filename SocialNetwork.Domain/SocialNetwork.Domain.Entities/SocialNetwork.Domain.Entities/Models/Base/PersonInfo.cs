
namespace SocialNetwork.Domain.Entities.Models.Base
{
    public class PersonInfo
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EMailAdress { get; set; }
        public int Password { get; set; }


        PersonInfo()
        {

        }
    }
}
