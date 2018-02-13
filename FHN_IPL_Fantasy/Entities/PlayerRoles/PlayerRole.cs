using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.PlayerRole
{
    public class PlayerRole
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        public string RoleSubType { get; set; }
    }
}
