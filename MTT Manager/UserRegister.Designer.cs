namespace MTT_Manager
{
    partial class UserRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_nickname = new System.Windows.Forms.TextBox();
            this.CB_verified = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BT_revealPW = new System.Windows.Forms.Button();
            this.TB_password = new System.Windows.Forms.TextBox();
            this.BT_login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_nickname
            // 
            this.TB_nickname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_nickname.Location = new System.Drawing.Point(103, 126);
            this.TB_nickname.MaxLength = 10;
            this.TB_nickname.Name = "TB_nickname";
            this.TB_nickname.Size = new System.Drawing.Size(267, 20);
            this.TB_nickname.TabIndex = 0;
            // 
            // CB_verified
            // 
            this.CB_verified.AutoSize = true;
            this.CB_verified.Cursor = System.Windows.Forms.Cursors.Default;
            this.CB_verified.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CB_verified.Location = new System.Drawing.Point(376, 172);
            this.CB_verified.Name = "CB_verified";
            this.CB_verified.Size = new System.Drawing.Size(79, 18);
            this.CB_verified.TabIndex = 1;
            this.CB_verified.Text = "Verificado";
            this.CB_verified.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NickName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-Mail";
            // 
            // TB_email
            // 
            this.TB_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_email.Location = new System.Drawing.Point(103, 170);
            this.TB_email.Name = "TB_email";
            this.TB_email.Size = new System.Drawing.Size(267, 20);
            this.TB_email.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(280, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MTT_Manager.Properties.Resources.MTT_Logo_;
            this.pictureBox1.Location = new System.Drawing.Point(186, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // BT_revealPW
            // 
            this.BT_revealPW.BackgroundImage = global::MTT_Manager.Properties.Resources.eye_close_1;
            this.BT_revealPW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_revealPW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_revealPW.Location = new System.Drawing.Point(338, 213);
            this.BT_revealPW.Name = "BT_revealPW";
            this.BT_revealPW.Size = new System.Drawing.Size(32, 20);
            this.BT_revealPW.TabIndex = 10;
            this.BT_revealPW.TabStop = false;
            this.BT_revealPW.UseVisualStyleBackColor = true;
            // 
            // TB_password
            // 
            this.TB_password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TB_password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.TB_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_password.Location = new System.Drawing.Point(103, 213);
            this.TB_password.Name = "TB_password";
            this.TB_password.Size = new System.Drawing.Size(236, 20);
            this.TB_password.TabIndex = 11;
            // 
            // BT_login
            // 
            this.BT_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_login.Location = new System.Drawing.Point(40, 246);
            this.BT_login.Name = "BT_login";
            this.BT_login.Size = new System.Drawing.Size(150, 45);
            this.BT_login.TabIndex = 12;
            this.BT_login.Text = "Ingresar";
            this.BT_login.UseVisualStyleBackColor = true;
            this.BT_login.Click += new System.EventHandler(this.BT_login_Click);
            // 
            // UserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 303);
            this.Controls.Add(this.BT_login);
            this.Controls.Add(this.BT_revealPW);
            this.Controls.Add(this.TB_password);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_verified);
            this.Controls.Add(this.TB_nickname);
            this.Name = "UserRegister";
            this.Text = "UserRegister";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserRegister_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_nickname;
        private System.Windows.Forms.CheckBox CB_verified;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BT_revealPW;
        private System.Windows.Forms.TextBox TB_password;
        private System.Windows.Forms.Button BT_login;
    }
}