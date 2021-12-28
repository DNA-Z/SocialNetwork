using SocialNetwork.ApplicationUseCases.ViewModels;

namespace SocialNetwork.ApplicationUseCases.Interfaces
{
    public interface IPersonService
    {
        /// <summary>
        /// Метод, возвращающий коллекцию Person
        /// </summary>
        /// <returns></returns>
        PersonViewModel GetPerson();
    }
}
