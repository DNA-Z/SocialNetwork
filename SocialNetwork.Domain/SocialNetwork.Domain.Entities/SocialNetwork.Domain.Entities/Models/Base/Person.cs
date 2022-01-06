
namespace SocialNetwork.Domain.Entities.Models.Base
{
    public class Person
    {
        public Guid Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EMailAdress { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        //public bool Completed { get; set; } = false;
        public Role Role { get; set; } = Role.User;   // ? // Роль в чате
        public Guid? ChatRoomId { get; set; }                // Внешний ключ на таблицу 
        public ChatRoom ChatRoom { get; set; }                  // Навигационное св-во на группу чата

        private List<string> chatLog = new List<string>();

        public Person(string FirstName, string LastName, string NickName, DateTime DateOfBirth, string EMailAdress, string Password)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.NickName = NickName;
            Age = Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(DateOfBirth.Year);
            this.EMailAdress = EMailAdress;
            Login = EMailAdress;
            this.Password = Password;
        }

        public void Receive(Guid sender, ChatMessage message)
        {
            string s = $"{sender}: {message}";
            chatLog.Add(s);
        }

        public void Say(ChatMessage message)
            => ChatRoom.Broadcast(Id, message);

        public void PrivateMessage(Guid who, ChatMessage message)
        {
            ChatRoom.Message(Id, who, message);            
        }
    }
}