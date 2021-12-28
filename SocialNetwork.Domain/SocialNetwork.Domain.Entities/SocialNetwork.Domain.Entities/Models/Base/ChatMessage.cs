
namespace SocialNetwork.Domain.Entities.Models.Base
{
    public class ChatMessage
    {
        public int MessageId { get; set; }
        public Person From { get; set; }
        public DateTime DateMessageWritten { get; set; }
        public string TextMessage { get; set; }

    }
}
