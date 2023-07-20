using Firebase.Database.Query;
using MTT_Manager.Properties;
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
    public partial class ConfirmWithPassword : Form
    {
        public static TaskCompletionSource<bool> tcs;
        MainFrame parent;

        public ConfirmWithPassword(MainFrame myparent)
        {
            InitializeComponent();
            tcs = new TaskCompletionSource<bool>();
            parent = myparent;
            parent.Enabled = false;
            this.Show();
            this.Focus();

            passInput.UseSystemPasswordChar = true;
        }

        private void ConfirmWithPassword_Load(object sender, EventArgs e)
        {

        }

        public async void CheckPass()
        {
            bool result = false;

            var nickNameRef = FireBaseControl.client.Child("users").Child(FireBaseControl.currentID).Child("Password");
            var nickNameSnapshot = await nickNameRef.OnceSingleAsync<string>();
            string myPass = nickNameSnapshot ?? string.Empty;
            if (passInput.Text == myPass)
            {
                result = true;
                
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            SetResponde(result);
        }

        public void SetResponde(bool result)
        {
            tcs.SetResult(result);
            parent.Enabled = true;
            this.Close();
        }

        public async Task<bool> GetResponse()
        {    

            return await tcs.Task;
        }

        private void BT_login_Click(object sender, EventArgs e)
        {
            CheckPass();
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            SetResponde(false);
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
    }
}
