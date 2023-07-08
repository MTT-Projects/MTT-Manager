using Firebase.Auth;
using Firebase.Auth.Providers;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static IFirebaseClient client;
        public static UserCredential currentUser;


        public static void InitializeFirebase()
        {

            try
            {
                client = new FireSharp.FirebaseClient(config); 
                authConfig.Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()
                };
                FireBaseControl.auth = new FirebaseAuthClient(authConfig);
            }
            catch (FirebaseAuthException ex)
            {
                MessageBox.Show("Error al inicializar el servicio de FireBase: " + ex.Message, "Error de FireBase", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
