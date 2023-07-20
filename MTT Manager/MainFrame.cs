﻿using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Offline;
using Firebase.Database.Query;
using MTT_Manager.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;


namespace MTT_Manager
{
    public partial class MainFrame : Form
    {
        private List<User> userList;

        private Dictionary<string, GameData> tempGamesList;

        private string currentUserID;

        private User currentUser; 
        public MainFrame()
        {
            InitializeComponent();
            LoadDatabase();
            Text = FireBaseControl.auth.User.Info.Email;
            mySplitContainer.Panel1.Enabled = false;

        }

        public async void LoadDatabase()
        {
            await LoadDataFromFirebaseDatabase(dataView);
        }

        public async Task UploadProfilePicture(string userID)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";
            openFileDialog.Title = "Seleccionar imagen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var loadMessage = InfoBox.ShowMessage(this,"Subiendo archivo al Almacenamiento", "Subiendo archivo", MessageBoxIcon.Information);
                var imagePath = openFileDialog.FileName;
                var resizedImage = ResizeImage(imagePath, 250);

                // Obtener el IsAdmin del usuario correspondiente a la uid del auth

                var imageRef = FireBaseControl.storageRef
                    .Child("ProfilePics")
                    .Child($"{userID}.png");

                var task = imageRef.PutAsync(resizedImage);

                task.Progress.ProgressChanged += (s, e) => Console.WriteLine($"Progreso: {e.Percentage} %");

                await task;
                loadMessage.Dispose();
            }
        }


        private static Stream ResizeImage(string imagePath, int maxWidth)
        {
            using (var image = Image.FromFile(imagePath))
            {
                int newWidth, newHeight;
                if (image.Width > maxWidth)
                {
                    newWidth = maxWidth;
                    newHeight = (int)(image.Height * ((float)maxWidth / image.Width));
                }
                else
                {
                    newWidth = image.Width;
                    newHeight = image.Height;
                }

                var resizedImage = new Bitmap(newWidth, newHeight);
                using (var graphics = Graphics.FromImage(resizedImage))
                {
                    graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    graphics.DrawImage(image, 0, 0, newWidth, newHeight);
                }

                var memoryStream = new MemoryStream();
                resizedImage.Save(memoryStream, ImageFormat.Png);
                memoryStream.Position = 0;

                return memoryStream;
            }
        }




        private async Task<Image> LoadImageFromFirebaseStorage(string imageUrl)
        {
            using (var webClient = new WebClient())
            {
                var imageBytes = await webClient.DownloadDataTaskAsync(imageUrl);
                var stream = new MemoryStream(imageBytes);
                var image = Image.FromStream(stream);

                return image;
            }
        }

        private async Task LoadDataFromFirebaseDatabase(DataGridView dataGridView)
        {
            var usersSnapshot = await FireBaseControl.client.Child("users").OnceAsync<User>();

            userList = new List<User>();

            foreach (var userSnapshot in usersSnapshot)
            {
                var user = userSnapshot.Object;
                user.UserId = userSnapshot.Key;
                userList.Add(user);
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
           // Application.Exit();
        }

        private void menu_sesion_logout_Click(object sender, EventArgs e)
        {
            if (MSG.YesNoMessage("¿Estás seguro de cerrar sesión?", "Confirmación de cierre", MessageBoxIcon.Warning))
            {
                this.Dispose();
                SingOut();
                LoginFrame.instance.ResetFrame();
                LoginFrame.instance.Visible = true;
            }
        }




        async Task<Image> GetUserImage(string userID)
        {
            string imageRef = await FireBaseControl.storageRef
                   .Child("ProfilePics")
                   .Child($"{userID}.png").GetDownloadUrlAsync();
            return await LoadImageFromFirebaseStorage(imageRef);
        }

        async Task<Image> SetUserImage(FileStream image, string userID)
        {
            string imageRef = await FireBaseControl.storageRef
                   .Child("ProfilePics")
                   .Child($"{userID}.png").GetDownloadUrlAsync();
            return await LoadImageFromFirebaseStorage(imageRef);
        }

        void ClearUserView()
        {
            currentUserID = "";
            currentUser = null;
            userNickName.Text = "";
            userIDLabel.Text = "";
            EmailLabel.Text = "";
            PasswordLabel.Text = "";

            registerDateLabel.Text = "";
            LastLoginLabel.Text = "";
            LastBanLabel.Text = "";

            Game_HighScore_date.Text = "";

            game_HighScoreLabel.Text = "";

            Game_LastScore_date.Text = "";

            gameLastScoreLabel.Text = "";


            mySplitContainer.Panel1.Enabled = false;

            BT_Ban.BackgroundImage = new Bitmap(Resources.Ban_icon, 35, 35);
            BT_admin.BackgroundImage = new Bitmap(Resources.admin_icon, 35, 35);
            Pic_AccountState.Image = Resources.NoVerified_icon;

            tempGamesList = new Dictionary<string, GameData>();
            GamesListBox.DataSource = null;
        }

        async void SetUserView(string userID)
        {
            ClearUserView();
            var loadMessage = InfoBox.ShowMessage(this,$"Cargando datos del usuario:\n{userID}.\nPor favor espere", "Cargando", MessageBoxIcon.Information);

            try
            {
                if (userID != null)
                {
                    User myUser = await GetUserData(userID);
                    currentUserID = userID;
                    try
                    {
                        userPicture.Image = await GetUserImage(userID);
                    }
                    catch
                    {
                        userPicture.Image = Resources.defaultPic;
                    }
                    currentUser = myUser;

                    mySplitContainer.Panel1.Enabled = true;

                    userNickName.Text = myUser.NickName;
                    userIDLabel.Text = userID;
                    EmailLabel.Text = myUser.Email;
                    PasswordLabel.Text = string.Join("", Enumerable.Repeat("*", myUser.Password.Count()));

                    registerDateLabel.Text = myUser.RegistrationDate == DateTime.MinValue
                    ? "No establecido"
                    : myUser.RegistrationDate.ToString("[dd/MM/yyyy | HH:mm:ss | GMT]");
                    LastLoginLabel.Text = myUser.LastLogin == DateTime.MinValue
                    ? "No establecido"
                    : myUser.LastLogin.ToString("[dd/MM/yyyy | HH:mm:ss | GMT]");
                    LastBanLabel.Text = myUser.LastBan == DateTime.MinValue
                    ? "No establecido"
                    : myUser.LastBan.ToString("[dd/MM/yyyy | HH:mm:ss | GMT]");

                    BT_Ban.BackgroundImage = new Bitmap(myUser.IsBanned ? Resources.Banned_icon : Resources.Ban_icon, 35, 35);
                    BT_admin.BackgroundImage = new Bitmap(myUser.IsAdmin ? Resources.Unadmin_icon : Resources.admin_icon, 35, 35);
                    Pic_AccountState.Image = myUser.AccountActive ? Resources.Verifed_icon : Resources.NoVerified_icon;

                    try
                    {
                        tempGamesList = new Dictionary<string, GameData>();

                        foreach (var game in myUser.PlayedGames)
                        {
                            tempGamesList[game.Key] = game.Value;
                        }

                        GamesListBox.DataSource = new BindingSource(tempGamesList, null);
                        GamesListBox.DisplayMember = "Key";
                        GamesListBox.ValueMember = "Value";

                        GamesListBox.Enabled = true;
                        GameDataSetView(tempGamesList.Keys.ToArray()[0]);
                    }
                    catch
                    {
                        GamesListBox.DataSource = null;
                        GamesListBox.SelectedText = "No Played Games";
                        GamesListBox.Enabled = false;
                    }



                }
                loadMessage.Close();
            }
            catch
            {
                loadMessage.Close();
                MessageBox.Show("No se a podido cargar al usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        public async Task<User> GetUserData(string userID)
        {
            User user = null;
            var userJson = await FireBaseControl.client.Child("users").Child(userID).OnceAsJsonAsync();
            if(userJson != null)
            {
                user = JsonConvert.DeserializeObject<User>(userJson);
                user.UserId = userID;
            }

            return user;
        }

        private void dataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            if (row != -1)
                SetUserView(userList[row].UserId);
        }

        private async void userPicture_DoubleClick(object sender, EventArgs e)
        {
            if (currentUserID != "")
            {
                await UploadProfilePicture(currentUserID);
            }
        }

        private void dataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BT_revealPW_MouseDown(object sender, MouseEventArgs e)
        {
            PasswordLabel.Text = currentUser.Password;
            BT_revealPW.BackgroundImage = Resources.eye_open_2;
        }

        private void BT_revealPW_MouseUp(object sender, MouseEventArgs e)
        {
            PasswordLabel.Text = string.Join("", Enumerable.Repeat("*", currentUser.Password.Count()));
            BT_revealPW.BackgroundImage = Resources.eye_close_1;
        }

        private void BT_Ban_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Hide(BT_Ban);
            if (currentUser != null)
            {
                if (currentUser.IsBanned)
                {
                    toolTip.Show("Un-Ban User", BT_Ban);
                }
                else
                {
                    toolTip.Show("Ban User", BT_Ban);
                }
            }
        }

        

        void GameDataSetView(string key)
        {
            if (tempGamesList.ContainsKey(key))
            {
                Game_HighScore_date.Text = tempGamesList[key].HighScoreDate == DateTime.MinValue
                    ? "No establecido"
                    : tempGamesList[key].HighScoreDate.ToString("[dd/MM/yyyy | HH:mm:ss | GMT]");

                game_HighScoreLabel.Text = tempGamesList[key].HighScore.ToString();

                Game_LastScore_date.Text = tempGamesList[key].LastScoreDate == DateTime.MinValue
                    ? "No establecido"
                    : tempGamesList[key].LastScoreDate.ToString("[dd/MM/yyyy | HH:mm:ss | GMT]");

                gameLastScoreLabel.Text = tempGamesList[key].LastScore.ToString();
            }
        }

        private void GamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (currentUser != null && currentUser.PlayedGames != null)
                {
                    if (GamesListBox.Enabled)
                    {
                        string key = GamesListBox.SelectedItem.ToString();
                        GameDataSetView(key);
                    }
                }
            }
            catch
            {

            }
        }

        async void BanCurrentUser()
        {
            if (currentUser.UserId != FireBaseControl.auth.User.Uid)
            {
                if (!currentUser.IsBanned)
                {
                    await FireBaseControl.client.Child("users").Child(currentUser.UserId).Child("IsBanned").PutAsync<bool>(true);
                    await FireBaseControl.client.Child("users").Child(currentUser.UserId).Child("LastBan").PutAsync<DateTime>(DateTime.Now);
                    currentUser.IsBanned = true;
                    currentUser.LastBan = DateTime.Now;
                    LastBanLabel.Text = currentUser.LastBan == DateTime.MinValue
                        ? "No establecido"
                        : currentUser.LastBan.ToString("[dd/MM/yyyy | HH:mm:ss | GMT]");
                }
                else
                {
                    await FireBaseControl.client.Child("users").Child(currentUser.UserId).Child("IsBanned").PutAsync<bool>(false);
                    currentUser.IsBanned = false;
                }
                BT_Ban.BackgroundImage = new Bitmap(currentUser.IsBanned ? Resources.Banned_icon : Resources.Ban_icon, 35, 35);
            }
            else
            {
                MessageBox.Show("¡No puedes Banearte a ti mismo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BT_Ban_Click(object sender, EventArgs e)
        {
            if (currentUser != null)
                BanCurrentUser();
        }

        async void AdminCurrentUser()
        {
            if (currentUser.UserId != FireBaseControl.auth.User.Uid)
            {
                if (!currentUser.IsAdmin)
                {
                    await FireBaseControl.client.Child("users").Child(currentUser.UserId).Child("IsAdmin").PutAsync<bool>(true);
                    currentUser.IsAdmin = true;
                }
                else
                {
                    await FireBaseControl.client.Child("users").Child(currentUser.UserId).Child("IsAdmin").PutAsync<bool>(false);
                    currentUser.IsAdmin = false;
                }
                BT_admin.BackgroundImage = new Bitmap(currentUser.IsAdmin ? Resources.Unadmin_icon : Resources.admin_icon, 35, 35);
            }
            else
            {
                MessageBox.Show("¡No puedes quitarte el administrador a ti mismo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BT_admin_Click(object sender, EventArgs e)
        {
            if (currentUser != null)
                AdminCurrentUser();
        }

        private void BT_admin_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Hide(BT_admin);
            if (currentUser != null)
            {
                if (currentUser.IsAdmin)
                {
                    toolTip.Show("Remove Administration", BT_admin);
                }
                else
                {
                    toolTip.Show("Give Administration", BT_admin);
                }
            }
        }

        private void Pic_AccountState_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Hide(Pic_AccountState);
            if (currentUser != null)
            {
                if (currentUser.AccountActive)
                {
                    toolTip.Show("Account activate", Pic_AccountState);
                }
                else
                {
                    toolTip.Show("Account Not activate", Pic_AccountState);
                }
            }

        }

        private void BT_refresh_user_Click(object sender, EventArgs e)
        {
            if(currentUser != null)
            {
                SetUserView(currentUser.UserId);
            }
        }

        private void MainFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void imprimirReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PdfGenerator.PrintUsersData(userList);
        }
    }
}
