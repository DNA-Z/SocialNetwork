using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SocialNetwork.Infrastructure.Data.Contexts
{
    public class SocialNetworkDbContext : DbContext
    {
        static SocialNetworkDbContext()
        {

        }
    }
}
