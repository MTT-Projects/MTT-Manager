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



    }
}
