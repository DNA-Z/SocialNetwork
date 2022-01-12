
namespace SocialNetwork.Domain.Entities.Models.Base
{
    public class Message
    {
        public Guid MessageId { get; set; }

        //public Person From { get; set; }      //  ?
        public DateTime DateMessageWritten { get; set; }
        public string TextMessage { get; set; }

        public Message(string textMessage)
        {
            TextMessage = textMessage;
            DateMessageWritten = DateTime.Now;
        }
    }
}
