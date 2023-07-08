using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTT_Manager
{
    public class User
    {
        public string UserId { get; set; }
        public string NickName { get; set; }
        [Browsable(false)]
        public Dictionary<string, GameData> PlayedGames { get; set; }
        public string Email { get; set; }

        [Browsable(false)]
        public bool IsAdmin { get; set; }
        [Browsable(false)]
        public bool IsBanned { get; set; }
        [Browsable(false)]
        public string Password { get; set; }
    }

    public class GameData
    {
        public int HighScore { get; set; }
        public int LastScore { get; set; }
    }
}
