using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.UserRole
{
    public class UsrRole
    {
        public int ID { get; set; }
        public Users.User User { get; set; }
        public AppRoles AppRoles { get; set; }
    }
}
