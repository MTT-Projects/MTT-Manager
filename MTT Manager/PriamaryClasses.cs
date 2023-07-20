using Firebase.Auth;
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
        [Browsable(false)]
        public DateTime RegistrationDate { get; set; }
        [Browsable(false)]
        public DateTime LastLogin { get; set; }
        [Browsable(false)]
        public DateTime LastBan { get; set; }
        [Browsable(false)]
        public bool AccountActive { get; set; }

        // Constructor por defecto
        public User()
        {
            PlayedGames = new Dictionary<string, GameData>();
        }
    }

    public class GameData
    {
        public int position { get; set; }
        public string userID { get; set; }
        public string NickName { get; set; }
        public int HighScore { get; set; }
        public int LastScore { get; set; }
        public DateTime HighScoreDate { get; set; }
        public DateTime LastScoreDate { get; set; }
    }

    public class GlobalGame
    {
        public Dictionary<string, GameData> PlayerScores { get; set; }
    }

    public class GamesList
    {
        public Dictionary<string, GlobalGame> Games = new Dictionary<string, GlobalGame>();
    }

    public class CustomToken : FirebaseCredential
    {
        public CustomToken(FirebaseCredential token)
        {
            this.RefreshToken = token.RefreshToken;
            this.ProviderType = token.ProviderType;
            this.Created = token.Created;
            this.ExpiresIn = token.ExpiresIn;
            this.IdToken = token.IdToken;
        }
            public Dictionary<string, dynamic> Params = new Dictionary<string, dynamic>();
    }
}
