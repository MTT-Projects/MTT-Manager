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
using MTT_Manager.Properties;
using System.Drawing.Imaging;
using System.IO;
using Firebase.Auth;
using System.Runtime.Serialization.Formatters;
using Newtonsoft.Json;
using Firebase.Database.Query;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace MTT_Manager
{
    public partial class UserEditor : Form
    {
        public MainFrame parent;
        public User userData;
        public Dictionary<string, GameData> tempGamesList;
        string firstJson = "";
        Stream newImage = null;
        string currentGameKey = "";

        int check = 0;

        public UserEditor(MainFrame myParent, User myUserData)
        {
            parent = myParent;
            userData = myUserData;
            tempGamesList = parent.tempGamesList;

            firstJson = JsonConvert.SerializeObject(myUserData);
            InitializeComponent();

            if (parent != null)
                parent.Enabled = false;

            SetData();
        }

        void SetData()
        {

            try
            {

                User myUser = userData;

                    userPicture.Image = parent.userPicture.Image;


                    TB_NickName.Text = myUser.NickName;
                    userID_Label.Text = myUser.UserId;
                    TB_email.Text = myUser.Email;
                    TB_Pass.Text = myUser.Password;

                    RegistrationDate.Value = myUser.RegistrationDate;
                    LastLoginDate.Value = myUser.LastLogin == DateTime.MinValue
                    ? LastLoginDate.MinDate
                    : myUser.LastLogin;
                    LastBanDate.Value= myUser.LastBan == DateTime.MinValue
                    ? LastBanDate.MinDate
                    : myUser.LastBan; 

                    isAdmin_check.Checked = myUser.IsAdmin;
                    isBanned_check.Checked = myUser.IsBanned;

                    if (userData.UserId == FireBaseControl.auth.User.Uid)
                    {
                        isAdmin_check.Enabled = false;
                        isBanned_check.Enabled = false;
                    }

                    try
                    {
                        tempGamesList = parent.tempGamesList;

                        foreach (var game in myUser.PlayedGames)
                        {
                            tempGamesList[game.Key] = game.Value;
                        }

                        GamesListBox.DataBindings.Clear();
                        GamesListBox.DataSource = new BindingSource(tempGamesList, null);
                        GamesListBox.DisplayMember = "Key";
                        GamesListBox.ValueMember = "Value";

                        GamesListBox.Enabled = true;
                        ScoresPanel.Enabled = true;

                        currentGameKey = tempGamesList.Keys.ToArray()[0];
                        GameDataSetView(currentGameKey);
                    }
                    catch
                    {
                        GamesListBox.DataSource = null;
                        GamesListBox.SelectedText = "No Played Games";
                        GamesListBox.Enabled = false;
                        ScoresPanel.Enabled = false;
                    }



            }
            catch
            {
                MessageBox.Show("No se a podido cargar al usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        void GameDataSetView(string key)
        {

            if (tempGamesList.ContainsKey(key))
            {
                HighScore_Date.Value = tempGamesList[key].HighScoreDate;
                HighScore_value.Value = tempGamesList[key].HighScore;
                LastScore_Date.Value = tempGamesList[key].LastScoreDate;
                LastScore_Value.Value = tempGamesList[key].LastScore;
            }
        }

        private void BT_revealPW_MouseDown(object sender, MouseEventArgs e)
        {
            TB_Pass.UseSystemPasswordChar = false;
            BT_revealPW.BackgroundImage = Resources.eye_open_2;
        }

        private void BT_revealPW_MouseUp(object sender, MouseEventArgs e)
        {
            TB_Pass.UseSystemPasswordChar = true;
            BT_revealPW.BackgroundImage = Resources.eye_close_1;
        }


        private void UserEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(parent != null)
                parent.Enabled = true;
        }

        private void passInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void GamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (userData != null && userData.PlayedGames != null)
                {
                    if (GamesListBox.Enabled && check >= 1) 
                    {
                        string key = GamesListBox.Text;
                        updateGameDataToObject(currentGameKey);
                        currentGameKey = key;
                        GameDataSetView(key);
                    }
                    else
                        check++;
                }
            }
            catch
            {

            }
        }

        public void UploadProfilePicture()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";
            openFileDialog.Title = "Seleccionar imagen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var imagePath = openFileDialog.FileName;
                newImage = ResizeImage(imagePath, 250);


                using (Stream resizedStream = ResizeImage(imagePath, 250))
                {
                    Image resizedImage = Image.FromStream(resizedStream);
                    userPicture.Image = resizedImage;
                }


            }
        }

        void updateGameDataToObject(string key)
        {
            if (tempGamesList.ContainsKey(key))
            {
                tempGamesList[key].LastScoreDate = LastScore_Date.Value;
                tempGamesList[key].HighScoreDate = HighScore_Date.Value;
                tempGamesList[key].LastScore = (int)LastScore_Value.Value;
                tempGamesList[key].HighScore = (int)HighScore_value.Value;
            }
        }

        public void SetDataToObjet()
        {
            userData.RegistrationDate = RegistrationDate.Value;
            userData.LastLogin = LastLoginDate.Value;
            if (LastBanDate.Value != LastBanDate.MinDate)
                userData.LastBan = LastBanDate.Value;
            else
                userData.LastBan = DateTime.MinValue;
            userData.NickName = TB_NickName.Text;
            userData.Email = TB_email.Text;
            userData.IsBanned=isBanned_check.Checked;
            userData.IsAdmin=isAdmin_check.Checked;

            updateGameDataToObject(currentGameKey);

            userData.PlayedGames = tempGamesList;
        }

        public async void SaveDataToDatabase()
        {
            var loadMessage = InfoBox.ShowMessage(this, "Subiendo archivo al Almacenamiento", "Subiendo archivo", MessageBoxIcon.Information);
            SetDataToObjet();


            string userJson = JsonConvert.SerializeObject(userData);

            //MessageBox.Show(userJson);
            if(firstJson != userJson)
            await FireBaseControl.client.Child("users").Child(userData.UserId).PutAsync(userJson);

            if (userData.PlayedGames != null)
            {
                foreach (var data in userData.PlayedGames)
                {
                    GameData myData = data.Value as GameData;
                    string myDataJson = JsonConvert.SerializeObject(myData);
                    var Reference = FireBaseControl.client.Child("scores").Child(data.Key).Child(userData.UserId);
                    await Reference.PutAsync(myDataJson);
                }
            }
            if (newImage != null)
            {
                // Obtener el IsAdmin del usuario correspondiente a la uid del auth
               

                var imageRef = FireBaseControl.storageRef
                    .Child("ProfilePics")
                    .Child($"{userData.UserId}.png");

                var task = imageRef.PutAsync(newImage);

                task.Progress.ProgressChanged += (s, e) => Console.WriteLine($"Progreso: {e.Percentage} %");

                await task;
               
            }


            loadMessage.Close();
            parent.SetUserView(userData.UserId);
            this.Close();
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

        private void ChangePicture_Click(object sender, EventArgs e)
        {
            UploadProfilePicture();
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de querer guardar la información?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SaveDataToDatabase();
            }
            
        }

        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void isAdmin_check_CheckedChanged(object sender, EventArgs e)
        {
            if (userData.UserId == FireBaseControl.auth.User.Uid && !isAdmin_check.Checked)
            {
                isAdmin_check.Checked = true;
                MessageBox.Show("¡No puedes quitarte el administrador a ti mismo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void isBanned_check_CheckedChanged(object sender, EventArgs e)
        {
            if (userData.UserId == FireBaseControl.auth.User.Uid && isBanned_check.Checked)
            {
                isBanned_check.Checked = false;
                MessageBox.Show("¡No puedes banearte a ti mismo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
