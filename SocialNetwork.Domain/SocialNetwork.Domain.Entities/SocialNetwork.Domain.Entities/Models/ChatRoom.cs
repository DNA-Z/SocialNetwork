using SocialNetwork.Domain.Entities.Models.Base;

namespace SocialNetwork.Domain.Entities.Models
{
    //Класс-посредник, где люди посылают сообщения в общий чат
    public class ChatRoom
    {
        public Guid Id { get; init; }
        public string NameChatRoom { get; set; }
        public List<Person> People { get; set; }

        public ChatRoom(string nameRoom)
        {
            NameChatRoom = nameRoom;
            People = new List<Person>();
        }

        /// <summary>
        /// Посылка сообщений в чате
        /// </summary>
        /// <param name="sourse">Кто послал сообщение</param>
        /// <param name="message">Текст сообщения</param>
        public void Broadcast(Guid sourse, ChatMessage message)
        {
            foreach(var p in People)
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
            People.Add(p);
        }

        /// <summary>
        /// Метод прямых сообщений
        /// </summary>
        /// <param name="source">Кто посылает сообщение</param>
        /// <param name="destination">Кому посылают сообщение</param>
        /// <param name="message">Текст сообщения</param>
        public void Message(Guid source, Guid destination, ChatMessage message)
        {
            People.FirstOrDefault(p => p.Id == destination)
                ?.Receive(source, message);
        }
    }
}
