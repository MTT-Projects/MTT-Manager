namespace MTT_Manager
{
    partial class UserEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEditor));
            this.ChangePicture = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_NickName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_email = new System.Windows.Forms.TextBox();
            this.ScoresPanel = new System.Windows.Forms.Panel();
            this.LastScore_Value = new System.Windows.Forms.NumericUpDown();
            this.HighScore_value = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.LastScore_Date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HighScore_Date = new System.Windows.Forms.DateTimePicker();
            this.HighscoreLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GamesListBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Pass = new System.Windows.Forms.TextBox();
            this.isAdmin_check = new System.Windows.Forms.CheckBox();
            this.isBanned_check = new System.Windows.Forms.CheckBox();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.RegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LastLoginDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.LastBanDate = new System.Windows.Forms.DateTimePicker();
            this.userID_Label = new System.Windows.Forms.Label();
            this.BT_revealPW = new System.Windows.Forms.Button();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.ScoresPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LastScore_Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighScore_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangePicture
            // 
            this.ChangePicture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangePicture.Location = new System.Drawing.Point(12, 171);
            this.ChangePicture.Name = "ChangePicture";
            this.ChangePicture.Size = new System.Drawing.Size(125, 23);
            this.ChangePicture.TabIndex = 1;
            this.ChangePicture.Text = "Change Picture";
            this.ChangePicture.UseVisualStyleBackColor = true;
            this.ChangePicture.Click += new System.EventHandler(this.ChangePicture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NickName";
            // 
            // TB_NickName
            // 
            this.TB_NickName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_NickName.Location = new System.Drawing.Point(147, 56);
            this.TB_NickName.Name = "TB_NickName";
            this.TB_NickName.Size = new System.Drawing.Size(272, 20);
            this.TB_NickName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // TB_email
            // 
            this.TB_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_email.Location = new System.Drawing.Point(147, 95);
            this.TB_email.Name = "TB_email";
            this.TB_email.ReadOnly = true;
            this.TB_email.Size = new System.Drawing.Size(272, 20);
            this.TB_email.TabIndex = 5;
            // 
            // ScoresPanel
            // 
            this.ScoresPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScoresPanel.Controls.Add(this.LastScore_Value);
            this.ScoresPanel.Controls.Add(this.HighScore_value);
            this.ScoresPanel.Controls.Add(this.label4);
            this.ScoresPanel.Controls.Add(this.LastScore_Date);
            this.ScoresPanel.Controls.Add(this.label7);
            this.ScoresPanel.Controls.Add(this.label8);
            this.ScoresPanel.Controls.Add(this.label5);
            this.ScoresPanel.Controls.Add(this.HighScore_Date);
            this.ScoresPanel.Controls.Add(this.HighscoreLabel);
            this.ScoresPanel.Controls.Add(this.label3);
            this.ScoresPanel.Location = new System.Drawing.Point(148, 194);
            this.ScoresPanel.Name = "ScoresPanel";
            this.ScoresPanel.Size = new System.Drawing.Size(272, 220);
            this.ScoresPanel.TabIndex = 6;
            // 
            // LastScore_Value
            // 
            this.LastScore_Value.Location = new System.Drawing.Point(10, 153);
            this.LastScore_Value.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.LastScore_Value.Name = "LastScore_Value";
            this.LastScore_Value.Size = new System.Drawing.Size(120, 20);
            this.LastScore_Value.TabIndex = 17;
            // 
            // HighScore_value
            // 
            this.HighScore_value.Location = new System.Drawing.Point(10, 47);
            this.HighScore_value.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.HighScore_value.Name = "HighScore_value";
            this.HighScore_value.Size = new System.Drawing.Size(120, 20);
            this.HighScore_value.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Date";
            // 
            // LastScore_Date
            // 
            this.LastScore_Date.CustomFormat = "dd/MM/yyyy H:mm";
            this.LastScore_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LastScore_Date.Location = new System.Drawing.Point(10, 192);
            this.LastScore_Date.Name = "LastScore_Date";
            this.LastScore_Date.Size = new System.Drawing.Size(200, 20);
            this.LastScore_Date.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(88, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "LAST SCORE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date";
            // 
            // HighScore_Date
            // 
            this.HighScore_Date.CustomFormat = "dd/MM/yyyy H:mm";
            this.HighScore_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HighScore_Date.Location = new System.Drawing.Point(10, 89);
            this.HighScore_Date.Name = "HighScore_Date";
            this.HighScore_Date.Size = new System.Drawing.Size(200, 20);
            this.HighScore_Date.TabIndex = 8;
            // 
            // HighscoreLabel
            // 
            this.HighscoreLabel.AutoSize = true;
            this.HighscoreLabel.Location = new System.Drawing.Point(7, 30);
            this.HighscoreLabel.Name = "HighscoreLabel";
            this.HighscoreLabel.Size = new System.Drawing.Size(34, 13);
            this.HighscoreLabel.TabIndex = 1;
            this.HighscoreLabel.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "HIGH SCORE";
            // 
            // GamesListBox
            // 
            this.GamesListBox.FormattingEnabled = true;
            this.GamesListBox.Location = new System.Drawing.Point(295, 171);
            this.GamesListBox.Name = "GamesListBox";
            this.GamesListBox.Size = new System.Drawing.Size(125, 21);
            this.GamesListBox.TabIndex = 7;
            this.GamesListBox.SelectedIndexChanged += new System.EventHandler(this.GamesListBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Contraseña";
            // 
            // TB_Pass
            // 
            this.TB_Pass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TB_Pass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.TB_Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Pass.Location = new System.Drawing.Point(147, 134);
            this.TB_Pass.Name = "TB_Pass";
            this.TB_Pass.ReadOnly = true;
            this.TB_Pass.Size = new System.Drawing.Size(232, 20);
            this.TB_Pass.TabIndex = 9;
            this.TB_Pass.UseSystemPasswordChar = true;
            this.TB_Pass.TextChanged += new System.EventHandler(this.passInput_TextChanged);
            // 
            // isAdmin_check
            // 
            this.isAdmin_check.AutoSize = true;
            this.isAdmin_check.Location = new System.Drawing.Point(11, 200);
            this.isAdmin_check.Name = "isAdmin_check";
            this.isAdmin_check.Size = new System.Drawing.Size(55, 17);
            this.isAdmin_check.TabIndex = 11;
            this.isAdmin_check.Text = "Admin";
            this.isAdmin_check.UseVisualStyleBackColor = true;
            this.isAdmin_check.CheckedChanged += new System.EventHandler(this.isAdmin_check_CheckedChanged);
            // 
            // isBanned_check
            // 
            this.isBanned_check.AutoSize = true;
            this.isBanned_check.Location = new System.Drawing.Point(11, 220);
            this.isBanned_check.Name = "isBanned_check";
            this.isBanned_check.Size = new System.Drawing.Size(63, 17);
            this.isBanned_check.TabIndex = 13;
            this.isBanned_check.Text = "Banned";
            this.isBanned_check.UseVisualStyleBackColor = true;
            this.isBanned_check.CheckedChanged += new System.EventHandler(this.isBanned_check_CheckedChanged);
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Cancel.Location = new System.Drawing.Point(244, 421);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(135, 45);
            this.BT_Cancel.TabIndex = 15;
            this.BT_Cancel.Text = "Cancel";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // BT_Save
            // 
            this.BT_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Save.Location = new System.Drawing.Point(41, 421);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(135, 45);
            this.BT_Save.TabIndex = 16;
            this.BT_Save.Text = "Save";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // RegistrationDate
            // 
            this.RegistrationDate.CustomFormat = "dd/MM/yyyy H:mm";
            this.RegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RegistrationDate.Location = new System.Drawing.Point(12, 267);
            this.RegistrationDate.Name = "RegistrationDate";
            this.RegistrationDate.Size = new System.Drawing.Size(125, 20);
            this.RegistrationDate.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "RegistrationDate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "LastLoginDate";
            // 
            // LastLoginDate
            // 
            this.LastLoginDate.CustomFormat = "dd/MM/yyyy H:mm";
            this.LastLoginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LastLoginDate.Location = new System.Drawing.Point(11, 317);
            this.LastLoginDate.Name = "LastLoginDate";
            this.LastLoginDate.Size = new System.Drawing.Size(125, 20);
            this.LastLoginDate.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 347);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "LastBanDate";
            // 
            // LastBanDate
            // 
            this.LastBanDate.CustomFormat = "dd/MM/yyyy H:mm";
            this.LastBanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LastBanDate.Location = new System.Drawing.Point(12, 366);
            this.LastBanDate.Name = "LastBanDate";
            this.LastBanDate.Size = new System.Drawing.Size(125, 20);
            this.LastBanDate.TabIndex = 21;
            // 
            // userID_Label
            // 
            this.userID_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userID_Label.Location = new System.Drawing.Point(11, 13);
            this.userID_Label.Name = "userID_Label";
            this.userID_Label.Size = new System.Drawing.Size(409, 23);
            this.userID_Label.TabIndex = 23;
            this.userID_Label.Text = "label12";
            this.userID_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BT_revealPW
            // 
            this.BT_revealPW.BackgroundImage = global::MTT_Manager.Properties.Resources.eye_close_1;
            this.BT_revealPW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_revealPW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_revealPW.Location = new System.Drawing.Point(377, 134);
            this.BT_revealPW.Name = "BT_revealPW";
            this.BT_revealPW.Size = new System.Drawing.Size(42, 20);
            this.BT_revealPW.TabIndex = 8;
            this.BT_revealPW.TabStop = false;
            this.BT_revealPW.UseVisualStyleBackColor = true;
            this.BT_revealPW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BT_revealPW_MouseDown);
            this.BT_revealPW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BT_revealPW_MouseUp);
            // 
            // userPicture
            // 
            this.userPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPicture.Image = global::MTT_Manager.Properties.Resources.MTT_Logo_;
            this.userPicture.Location = new System.Drawing.Point(12, 40);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(125, 125);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            // 
            // UserEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 476);
            this.Controls.Add(this.userID_Label);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LastBanDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LastLoginDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RegistrationDate);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.BT_Cancel);
            this.Controls.Add(this.isBanned_check);
            this.Controls.Add(this.isAdmin_check);
            this.Controls.Add(this.BT_revealPW);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_Pass);
            this.Controls.Add(this.GamesListBox);
            this.Controls.Add(this.ScoresPanel);
            this.Controls.Add(this.TB_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_NickName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangePicture);
            this.Controls.Add(this.userPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserEditor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserEditor_FormClosed);
            this.ScoresPanel.ResumeLayout(false);
            this.ScoresPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LastScore_Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighScore_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Button ChangePicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_NickName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_email;
        private System.Windows.Forms.Panel ScoresPanel;
        private System.Windows.Forms.Label HighscoreLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox GamesListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker HighScore_Date;
        private System.Windows.Forms.Button BT_revealPW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Pass;
        private System.Windows.Forms.NumericUpDown LastScore_Value;
        private System.Windows.Forms.NumericUpDown HighScore_value;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker LastScore_Date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox isAdmin_check;
        private System.Windows.Forms.CheckBox isBanned_check;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.DateTimePicker RegistrationDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker LastLoginDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker LastBanDate;
        private System.Windows.Forms.Label userID_Label;
    }
}