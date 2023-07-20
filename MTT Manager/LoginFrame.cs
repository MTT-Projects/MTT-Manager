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
                string nickName = await GetNickName(userId);

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
                MessageBox.Show(GetExceptionDesc(ex), "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetFrame();
                return false;
            }
        }

        public static string GetExceptionDesc(FirebaseAuthException ex)
        {
            string description = string.Empty;

            switch (ex.Reason)
            {
                case AuthErrorReason.Undefined:
                    description = "La solicitud no se completó, posiblemente debido a un problema de red.";
                    break;
                case AuthErrorReason.Unknown:
                    description = "Error desconocido.";
                    break;
                case AuthErrorReason.OperationNotAllowed:
                    description = "El método de inicio de sesión no está permitido.";
                    break;
                case AuthErrorReason.UserDisabled:
                    description = "El usuario está desactivado y no tiene acceso.";
                    break;
                case AuthErrorReason.UserNotFound:
                    description = "No se encontró un usuario.";
                    break;
                case AuthErrorReason.InvalidProviderID:
                    description = "El cuerpo de la solicitud no contiene o contiene un proveedor de autenticación no válido.";
                    break;
                case AuthErrorReason.InvalidAccessToken:
                    description = "El cuerpo de la solicitud no contiene o contiene un token de acceso no válido obtenido del proveedor de autenticación.";
                    break;
                case AuthErrorReason.LoginCredentialsTooOld:
                    description = "Se han realizado cambios en la cuenta del usuario desde el último inicio de sesión. \nEl usuario necesita iniciar sesión nuevamente.";
                    break;
                case AuthErrorReason.MissingRequestURI:
                    description = "La solicitud no contiene un valor para el parámetro: requestUri.";
                    break;
                case AuthErrorReason.SystemError:
                    description = "La solicitud no contiene un valor para el parámetro: postBody.";
                    break;
                case AuthErrorReason.InvalidEmailAddress:
                    description = "La dirección de correo electrónico no es válida.";
                    break;
                case AuthErrorReason.MissingPassword:
                    description = "¡No se proporcionó una contraseña!";
                    break;
                case AuthErrorReason.WeakPassword:
                    description = "La contraseña debe tener más de 6 caracteres.";
                    break;
                case AuthErrorReason.EmailExists:
                    description = "La dirección de correo electrónico ya está vinculada a otra cuenta.";
                    break;
                case AuthErrorReason.MissingEmail:
                    description = "¡No se proporcionó un correo electrónico!";
                    break;
                case AuthErrorReason.UnknownEmailAddress:
                    description = "No hay ningún usuario registrado con la dirección de correo electrónico proporcionada.";
                    break;
                case AuthErrorReason.WrongPassword:
                    description = "La contraseña proporcionada no es válida para la dirección de correo electrónico.";
                    break;
                case AuthErrorReason.TooManyAttemptsTryLater:
                    description = "Se han intentado demasiados inicios de sesión con contraseña. \nInténtalo de nuevo más tarde.";
                    break;
                case AuthErrorReason.MissingRequestType:
                    description = "La solicitud no contiene un valor para el parámetro: \nrequestType o el valor proporcionado es inválido.";
                    break;
                case AuthErrorReason.ResetPasswordExceedLimit:
                    description = "Se ha excedido el límite de restablecimiento de contraseña.";
                    break;
                case AuthErrorReason.InvalidIDToken:
                    description = "¡El token de ID de usuario autenticado no es válido!";
                    break;
                case AuthErrorReason.MissingIdentifier:
                    description = "La solicitud no contiene un valor para el parámetro: identifier.";
                    break;
                case AuthErrorReason.InvalidIdentifier:
                    description = "La solicitud contiene un valor no válido para el parámetro: identifier.";
                    break;
                case AuthErrorReason.AlreadyLinked:
                    description = "La cuenta que se intenta vincular ya está vinculada.";
                    break;
                case AuthErrorReason.InvalidApiKey:
                    description = "La clave de API especificada no es válida.";
                    break;
                case AuthErrorReason.AccountExistsWithDifferentCredential:
                    description = "El correo electrónico con el que el usuario intentó iniciar sesión ya está registrado en otro proveedor.";
                    break;
                default:
                    description = "Se ha producido un error en la autenticación:\n" + ex.Message;
                    break;
            }
            return description;
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

        private async Task<string> GetNickName(string userId)
        {
            var nickNameRef = FireBaseControl.client.Child("users").Child(userId).Child("NickName");
            var nickNameSnapshot = await nickNameRef.OnceSingleAsync<string>();
            string nickName = nickNameSnapshot ?? string.Empty;
            return nickName;
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
