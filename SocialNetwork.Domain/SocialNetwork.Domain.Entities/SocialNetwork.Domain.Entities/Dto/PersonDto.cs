//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SocialNetwork.Domain.Entities.Dto
//{
//    public class PersonDto
//    {
//        public Guid Id { get; init; }
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public string NickName { get; set; }
//        public int Age { get; set; }
//        public DateTime DateOfBirth { get; set; }
//        public string EMailAdress { get; set; }
//        public string Login { get; set; }
//        public LogInData LogIn { get; set; }          // Класс LogInData хранит email и пароль
//        public bool WillAttand { get; set; } = false;
//        public Role Role { get; set; } = Role.User;   // ? // Роль в чате
//        public Guid? ChatRoomId { get; set; }         // Внешний ключ на таблицу 
//        public List<ChatRoom> ChatRoom { get; set; }        // Навигационное св-во на группу чатов

//        private List<string> chatLog = new List<string>();
//    }
//}
