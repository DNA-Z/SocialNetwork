using SocialNetwork.Domain.Entities.Models.Base;

namespace SocialNetwork.Domain.Entities.Models
{
    //Класс-посредник, где люди посылают сообщения в общий чат
    public class ChatRoom
    {
        List<Person> people = new List<Person>();

        /// <summary>
        /// Метод "вещания" в чате
        /// </summary>
        /// <param name="sourse">Кто послал сообщение</param>
        /// <param name="message">Текст сообщения</param>
        public void Broadcast(string sourse, string message)
        {
            foreach(var p in people)
                if(p.LastName = sourse)
                    p.Receive(sourse, message);
        }

        public void JoinPerson(Person)
    }
}
