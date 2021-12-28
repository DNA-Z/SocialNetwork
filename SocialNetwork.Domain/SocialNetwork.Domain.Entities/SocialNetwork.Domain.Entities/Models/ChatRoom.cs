using SocialNetwork.Domain.Entities.Models.Base;

namespace SocialNetwork.Domain.Entities.Models
{
    //Класс-посредник, где люди посылают сообщения в общий чат
    public class ChatRoom
    {
        public Guid Id { get; set; }
        public string NameChatRoom { get; set; }

        List<Person> people = new List<Person>();

        /// <summary>
        /// Посылка сообщений в чате
        /// </summary>
        /// <param name="sourse">Кто послал сообщение</param>
        /// <param name="message">Текст сообщения</param>
        public void Broadcast(Guid sourse, ChatMessage message)
        {
            foreach(var p in people)
                if(p.Id == sourse)
                    p.Receive(sourse, message);
        }

        /// <summary>
        /// Добавление нового участника в группу чата
        /// </summary>
        /// <param name="p"></param>
        public void JoinPerson(Person p)
        {
            string joinMsg = $"{p.FirstName} {p.LastName} добавился(ась) в чат";

            Broadcast(Id, new ChatMessage(joinMsg));

            p.ChatRoom = this;
            people.Add(p);
        }

        /// <summary>
        /// Метод прямых сообщений
        /// </summary>
        /// <param name="source">Кто посылает сообщение</param>
        /// <param name="destination">Кому посылают сообщение</param>
        /// <param name="message">Текст сообщения</param>
        public void Message(Guid source, Guid destination, ChatMessage message)
        {
            people.FirstOrDefault(p => p.Id == destination)
                ?.Receive(source, message);
        }
    }
}
