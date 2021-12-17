﻿using SocialNetwork.Domain.Entities.Models.Base;

namespace SocialNetwork.Infrastructure.Data.DummyRepository
{
    public class Repository
    {
        public List<PersonInfo> PersonInformations { get; } = new List<PersonInfo>
        {
            new PersonInfo ( 1, "Tim", "Skold", "Tim_Skold", new DateTime(1966, 12, 14), "t.skold@gmail.com", "1Dfg153" ),
            new PersonInfo ( 2, "Timothy", "Linton", "Zim_Zam", new DateTime(1969, 06, 25), "zim.zam@gmail.com", "1423jF_153" ),
            new PersonInfo ( 3, "Jeordie", "White", "Twiggy_Ramirez", new DateTime(1971, 06, 20), "qwert@gmail.com", "AAAAvfdb235153" ),
            new PersonInfo ( 4, "John", "Lowery", "John_5", new DateTime(1970, 07, 31), "john5@gmail.com", "14235153" ),
            new PersonInfo ( 5, "Tyler", "Bates", "Tyler_Bates", new DateTime(1965, 06, 05), "tyler.bates@gmail.com", "qwerty14235153" ),
            new PersonInfo ( 6, "Chris", "Vrenna", "Chris_Vrenna", new DateTime(1969, 06, 25), "chris.vrenna@gmail.com", "QWERTY" ),
            new PersonInfo ( 7, "Fred", "Sablan", "Fred_Sablan", new DateTime(1970, 04, 28), "fr.sablan@gmail.com", "1423515_cDYC" ),
        };
    }
}
