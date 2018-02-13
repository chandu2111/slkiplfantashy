using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.PlayerRole;

namespace Entities.Players
{
    public class Player
    {
        public int ID { get; set; }

        public string PlayerName { get; set; }

        public PlayerRole.PlayerRole PlayerRole { get; set; }

    }
}
