using SocialNetwork.Domain.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.ApplicationUseCases.ViewModels
{
    public class PersonViewModel
    {
        public IEnumerable<Person> Persons { get; set; }
    }
}
