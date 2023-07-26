using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Database;
using FireSharp.Config;
using FireSharp.Interfaces;
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
using Firebase.Database.Query;
using FireSharp.Extensions;
using Newtonsoft.Json;
namespace MTT_Manager
{
    public partial class LoginFrame : Form
    {

        public LoginFrame()
        {
            instance = this;
            InitializeComponent();
            FireBaseControl.InitializeFirebase();
        }

        public static LoginFrame instance;
        public static string currentPass;


        private async Task<bool> SignInWithEmail(string email, string password)
        {
            var loadMessage = InfoBox.ShowMessage("Verificando datos de sesión\nPor favor espere", "Verificando", MessageBoxIcon.Information);

            try
            {
                UserCredential authLink = await FireBaseControl.auth.SignInWithEmailAndPasswordAsync(email, password);
                string userId = authLink.User.Uid;

                await FireBaseControl.SetAuth(email, password);

                // Verificar si el usuario es un administrador en la base de datos
                bool isAdmin = await CheckAdminStatus(userId);
                string nickName = await FireBaseControl.GetNickName(userId);

                loadMessage.Dispose();

                if (isAdmin)
                {
                    MessageBox.Show($"Bienvenido {nickName}.", "Inicio exitoso");
                    FireBaseControl.currentUser = authLink;
                    FireBaseControl.currentID = userId;
                    currentPass = password;
                    
                    return true;
                }
                else
                {
                    MessageBox.Show("No tienes permisos de administrador.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ResetFrame();
                    return false;
                }
            }
            catch (FirebaseAuthException ex)
            {
                loadMessage.Dispose();
                MessageBox.Show(FireBaseControl.GetExceptionDesc(ex), "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetFrame();
                return false;
            }
        }

        
        public void ResetFrame()
        {
            this.Enabled = true;
            this.Focus();
            emailInput.Text = "";
            passInput.Text = "";
            emailInput.Focus();
        }

        private async Task<bool> CheckAdminStatus(string userId)
        {
            
            User checkDataPlayer = await FireBaseControl.client
                .Child("users")
                .Child(userId)
                .OnceSingleAsync<User>();

            //MessageBox.Show(JsonConvert.SerializeObject(checkDataPlayer));
            
            return checkDataPlayer.IsAdmin;
        }

        

        private void BT_login_Click(object sender, EventArgs e)
        {
            LoginEvent();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                LoginEvent();
        }

        public async void LoginEvent()
        {
            string emailOrNickname = emailInput.Text;
            string password = passInput.Text;

            bool isLogin = await SignInWithEmail(emailOrNickname, password);

            if (isLogin)
            {
                MainFrame mainApp = new MainFrame();
                mainApp.Show();
                this.Visible = false;
            }
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BT_revealPW_MouseDown(object sender, MouseEventArgs e)
        {
            passInput.UseSystemPasswordChar = false;
            BT_revealPW.BackgroundImage = Resources.eye_open_2;
        }

        private void BT_revealPW_MouseUp(object sender, MouseEventArgs e)
        {
            passInput.UseSystemPasswordChar = true;
            BT_revealPW.BackgroundImage = Resources.eye_close_1;
        }

        private void passInput_Click(object sender, EventArgs e)
        {
            passInput.UseSystemPasswordChar = true;
        }

        private void emailInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                LoginEvent();
        }

        private void BT_revealPW_Click(object sender, EventArgs e)
        {

        }

        private void LoginFrame_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
