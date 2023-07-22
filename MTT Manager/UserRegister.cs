using System.Windows.Forms;
using MTT_Manager.Properties;
using Firebase.Auth;
using Firebase.Auth.Providers;
using System.Runtime.Serialization.Formatters;
using Firebase.Database.Query;
using System;
using Newtonsoft.Json;
using Firebase.Database;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace MTT_Manager
{
    public partial class UserRegister : Form
    {
        MainFrame parent;
        public UserRegister(MainFrame myParent)
        {
            parent = myParent;
            InitializeComponent();
            parent.Enabled = false;
            this.Focus();
        }

        public async Task<bool> RegisterNewUser()
        {
            var loadMessage = InfoBox.ShowMessage("Verificando datos de sesión\nPor favor espere", "Verificando", MessageBoxIcon.Information);


            FirebaseAuthConfig myConfig = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyAkzjBpqOcrwwFVhMVugseHFaYWVkGbFgY",
                AuthDomain = "catgamesucre.firebaseapp.com",
            };
            myConfig.Providers = new FirebaseAuthProvider[]
            {
                new EmailProvider()
            };

            string nickName = TB_nickname.Text;
            string email = TB_email.Text;
            string password = TB_password.Text;

            FirebaseAuthClient myAuth = new FirebaseAuthClient(myConfig);

            try
            {
                UserCredential newUserCredential = await myAuth.CreateUserWithEmailAndPasswordAsync(email, password, nickName);                
                string userId = newUserCredential.User.Uid;

                User newUser = new User
                {
                    NickName = nickName,
                    Email = email,
                    Password = password,
                    RegistrationDate = DateTime.Now,
                    AccountActive = false
                };

                string newUserJson = JsonConvert.SerializeObject(newUser);
                var newUserRef = FireBaseControl.client.Child("users").Child(userId);
                try
                {
                    await newUserRef.PutAsync(newUserJson);

                }
                catch(FirebaseException ex)
                {
                    MessageBox.Show($"User Registration Database error:\n{ex.Message}");
                }

                return true;
            }
            catch (FirebaseAuthException ex)
            {
                loadMessage.Dispose();
                MessageBox.Show(FireBaseControl.GetExceptionDesc(ex), "Error de registro de usuario.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetFrame();
                return false;
            }

        }
        public void ResetFrame()
        {
            TB_nickname.Text = "";
            TB_email.Text = "";
            TB_password.Text = "";
            TB_nickname.Focus();
        }

        private void BT_revealPW_MouseDown(object sender, MouseEventArgs e)
        {
            TB_password.UseSystemPasswordChar = false;
            BT_revealPW.BackgroundImage = Resources.eye_open_2;
        }

        private void BT_revealPW_MouseUp(object sender, MouseEventArgs e)
        {
            TB_password.UseSystemPasswordChar = true;
            BT_revealPW.BackgroundImage = Resources.eye_close_1;
        }

        private void TB_password_Click(object sender, EventArgs e)
        {
            TB_password.UseSystemPasswordChar = true;
        }

        private void BT_login_Click(object sender, EventArgs e)
        {
            Regitration_event();
        }

        public async void Regitration_event()
        {
            bool iscreate = await RegisterNewUser();

            if (iscreate)
            {
                MessageBox.Show("Usuario correctamente registrado.");
                parent.LoadDatabase();
                this.Close();
            }
            else
            {
                ResetFrame();
            }
        }

        private void UserRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Enabled = true;
            parent.Focus();
        }

        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Regitration_event();
        }

        private void emailInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                Regitration_event();
        }


        private void TB_nickname_Enter(object sender, EventArgs e)
        {
            TB_password.UseSystemPasswordChar = true;
        }

        private void TB_password_Enter(object sender, EventArgs e)
        {
            TB_password.UseSystemPasswordChar = true;
        }
    }


}
