using SocialNetwork.Domain.Entities.Models.Base;

namespace SocialNetwork.Domain.Entities.Models
{
    public class PersonAccount
    {
        public Person? Person { get; init; }

        public int NumberOfFriends { get; init; } = 0;


        public PersonAccount()
        {

        }
    }
}
