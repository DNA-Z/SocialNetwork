using Abp.Domain.Entities;
using SocialNetwork.Domain.Entities.Models.AuxiliaryModels;

namespace SocialNetwork.Domain.Entities.Models.Base
{
    public class Person : Entity//, IAggregateRoot
    {
        public Guid Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EMailAdress { get; set; }
        public string Login { get; set; }
        public LogInData LogIn { get; set; }          // Класс LogInData хранит email и пароль
        public bool WillAttand { get; set; } = false;
        public Role Role { get; set; } = Role.User;   // ? // Роль в чате
        public List<ChatRoom> ChatRoom { get; set; }
        public List<Message> Message { get; set; }

        //public ICollection<IEventData> DomainEvents => throw new NotImplementedException();

        //int IEntity<int>.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private List<string> chatLog = new List<string>();

        public Person(string FirstName, string LastName, string NickName, DateTime DateOfBirth, string EMailAdress)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.NickName = NickName;
            Age = Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(DateOfBirth.Year);
            this.EMailAdress = EMailAdress;
            Login = EMailAdress;
        }

        public void Receive(Guid sender, Message message)
        {
            string s = $"{sender}: {message}";
            chatLog.Add(s);
        }

        public void Say(Message message)
            => ChatRoom[0].Broadcast(Id, message);      // todo: [0]

        public void PrivateMessage(Guid who, Message message)
        {
            ChatRoom[0].Message(Id, who, message);      // todo: [0]  
        } 
    }
}