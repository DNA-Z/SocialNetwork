
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


        //Связь с Person один ко многим (т.е. один человек может написать много сообщений,
        //                                но одно и тоже сообщение может написать одни человек)
        public Guid PersonId { get; init; }    // Внешний ключ
        public Person Person { get; set; }     // Навигационное свойство
    }
}
