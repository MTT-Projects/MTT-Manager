using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTT_Manager
{
    public partial class UserEditor : Form
    {
        public UserEditor()
        {
            InitializeComponent();
        }

        private async Task<User> GetUserFromDatabase(string userId)
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "TU_AUTH_SECRET",
                BasePath = "TU_BASE_PATH"
            };

            IFirebaseClient client = new FireSharp.FirebaseClient(config);

            FirebaseResponse response = await client.GetAsync($"users/{userId}");
            User user = response.ResultAs<User>();

            return user;
        }

        private async Task RegisterGameForUser(string userId, string gameName, int score, int highScore)
        {
            User user = await GetUserFromDatabase(userId);

            if (user.PlayedGames == null)
            {
                user.PlayedGames = new Dictionary<string, GameData>();
            }

            GameData gameData = new GameData
            {
                LastScore = score,
                HighScore = highScore
            };

            if (user.PlayedGames.ContainsKey(gameName))
            {
                user.PlayedGames[gameName] = gameData;
            }
            else
            {
                user.PlayedGames.Add(gameName, gameData);
            }

            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "TU_AUTH_SECRET",
                BasePath = "TU_BASE_PATH"
            };

            IFirebaseClient client = new FireSharp.FirebaseClient(config);

            SetResponse response = await client.SetAsync($"users/{userId}", user);
        }
    }
}
