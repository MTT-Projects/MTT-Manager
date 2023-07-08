using Firebase.Auth;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MTT_Manager
{
    public partial class MainFrame : Form
    {
        private List<User> userList;
        public MainFrame()
        {
            InitializeComponent();
            Setimage();
            LoadDatabase();

            Text = FireBaseControl.auth.User.Info.Email;
        }

        public async void LoadDatabase()
        {
            await LoadDataFromFirebaseDatabase(dataView);
        }

        public async void Setimage()
        {
            string imageUrl = "https://firebasestorage.googleapis.com/v0/b/catgamesucre.appspot.com/o/3133286.jpg?alt=media";
            Image image = await LoadImageFromFirebaseStorage(imageUrl);
            pictureLogo.Image = image;
        }

        private async Task<Image> LoadImageFromFirebaseStorage(string imageUrl)
        {
            using (var webClient = new WebClient())
            {
                var imageBytes = await webClient.DownloadDataTaskAsync(imageUrl);
                var stream = new System.IO.MemoryStream(imageBytes);
                var image = Image.FromStream(stream);

                return image;
            }
        }

        private async Task LoadDataFromFirebaseDatabase(DataGridView dataGridView)
        {
            FirebaseResponse response = await FireBaseControl.client.GetAsync("users");

            Dictionary<string, object> data = response.ResultAs<Dictionary<string, object>>();

            userList = new List<User>();

            foreach (var userEntry in data)
            {
                string userId = userEntry.Key;
                var userJson = JsonConvert.SerializeObject(userEntry.Value);
                User userData = JsonConvert.DeserializeObject<User>(userJson);
                userData.UserId = userId;
                userList.Add(userData);
            }

            dataGridView.DataSource = userList;
        }

        private void BT_refresh_Click(object sender, EventArgs e)
        {
            LoadDatabase();
        }

        public void SingOut()
        {
            FireBaseControl.auth.SignOut();
        }


        private void MainFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void menu_sesion_logout_Click(object sender, EventArgs e)
        {
            if (MSG.YesNoMessage("¿Estas seguro de cerrar sesión?", "Confirmacion de cierre", MessageBoxIcon.Warning))
            {
                this.Dispose();
                SingOut();
                LoginFrame.instance.ResetFrame();
                LoginFrame.instance.Visible = true;
            }

            
        }
    }
}
