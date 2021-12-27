
namespace SocialNetwork.Domain.Entities.Models.Base
{
    public class PersonInfo
    {
        public Guid Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EMailAdress { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Completed { get; set; } = false;

        public ChatRoom Room;

        private List<string> chatLog = new List<string>();

        public PersonInfo(Guid Id, string FirstName, string LastName, string NickName, DateTime DateOfBirth, string EMailAdress, string Password)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.NickName = NickName;
            this.DateOfBirth = DateOfBirth;
            this.EMailAdress = EMailAdress;
            Login = EMailAdress;
            this.Password = Password;
        }

        public void Receive(string sender, string message)
        {
            string s = $"{sender}: {message}";
            chatLog.Add(s);
        }

        public void Say(string message)
            => Room.Broadcast(NickName, message);


    }
}
