using SocialNetwork.Domain.Entities.Models.Base;

namespace SocialNetwork.Infrastructure.Data.DummyRepository
{
    public class Repository
    {
        public List<Person> PersonInformations { get; } = new List<Person>
        {
            new Person ( "Tim", "Skold", "Tim_Skold", new DateTime(1966, 12, 14), "t.skold@gmail.com", "1Dfg153" ),
            new Person ( "Timothy", "Linton", "Zim_Zam", new DateTime(1969, 06, 25), "zim.zam@gmail.com", "1423jF_153" ),
            new Person ( "Jeordie", "White", "Twiggy_Ramirez", new DateTime(1971, 06, 20), "qwert@gmail.com", "AAAAvfdb235153" ),
            new Person ( "John", "Lowery", "John_5", new DateTime(1970, 07, 31), "john5@gmail.com", "14235153" ),
            new Person ( "Tyler", "Bates", "Tyler_Bates", new DateTime(1965, 06, 05), "tyler.bates@gmail.com", "qwerty14235153" ),
            new Person ( "Chris", "Vrenna", "Chris_Vrenna", new DateTime(1969, 06, 25), "chris.vrenna@gmail.com", "QWERTY" ),
            new Person ( "Fred", "Sablan", "Fred_Sablan", new DateTime(1970, 04, 28), "fr.sablan@gmail.com", "1423515_cDYC" ),
        };
    }
}
