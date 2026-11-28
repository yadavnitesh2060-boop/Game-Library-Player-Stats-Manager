using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Library___Player_Stats_Manager.Models
{
    public class Player
    {

        public string playerId { get; set; }
        public string username { get; set; }

        public Player(string playerId, string username)
        {
            this.playerId = playerId;
            this.username = username;
        }
    }
}
