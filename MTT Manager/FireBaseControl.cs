using Firebase.Auth;
using Firebase.Storage;
using Firebase.Auth.Providers;
using Firebase.Database;
using Firebase.Database.Query;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using System.Threading;
namespace MTT_Manager
{
    internal class FireBaseControl
    {
        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "qMaj162aIkxNQPaHOxcJmJyJW1uXZlKrYSxkM2cs",
            BasePath = "https://catgamesucre-default-rtdb.firebaseio.com/"
        };

        public static FirebaseAuthConfig authConfig = new FirebaseAuthConfig
        {
            ApiKey = "AIzaSyAkzjBpqOcrwwFVhMVugseHFaYWVkGbFgY",
            AuthDomain = "catgamesucre.firebaseapp.com",
        };

        public static FirebaseAuthClient auth;
        public static FirebaseClient client;
        public static UserCredential currentUser;
        public static FirebaseStorage storageRef;
        public static string currentID;

        public static void InitializeFirebase()
        {
            try
            {
                client = new FirebaseClient(config.BasePath, new FirebaseOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(config.AuthSecret)
                });

                authConfig.Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()
                };
                auth = new FirebaseAuthClient(authConfig);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar el servicio de FireBase: " + ex.Message, "Error de FireBase", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        



        public static async Task SetAuth(string email, string password)
        {
            var authLink = await auth.SignInWithEmailAndPasswordAsync(email, password);
            string token = await authLink.User.GetIdTokenAsync();

            var options = new FirebaseOptions
            {
                AuthTokenAsyncFactory = () => Task.FromResult(token),
            };

            var storageOptions = new FirebaseStorageOptions
            {
                AuthTokenAsyncFactory = () => Task.FromResult(token),
                ThrowOnCancel = true,
            };


            client = new FirebaseClient(config.BasePath, options);

            storageRef = new FirebaseStorage("catgamesucre.appspot.com", storageOptions);



        }

        public static async Task<string> GetNickName(string userId)
        {
            var nickNameRef = client.Child("users").Child(userId).Child("NickName");
            var nickNameSnapshot = await nickNameRef.OnceSingleAsync<string>();
            string nickName = nickNameSnapshot ?? string.Empty;
            return nickName;
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

    }
}
