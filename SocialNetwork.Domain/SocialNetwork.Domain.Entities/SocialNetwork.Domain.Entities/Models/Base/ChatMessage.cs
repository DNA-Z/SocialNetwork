
namespace SocialNetwork.Domain.Entities.Models.Base
{
    public class ChatMessage
    {
        public int Id { get; set; }
        public DateTime DateMessageWritten { get; set; }
        public string TextMessage { get; set; }

    }
}
