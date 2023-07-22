namespace MTT_Manager
{
    partial class ConfirmWithPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmWithPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.BT_revealPW = new System.Windows.Forms.Button();
            this.passInput = new System.Windows.Forms.TextBox();
            this.BT_Close = new System.Windows.Forms.Button();
            this.BT_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su contraseña para confirmar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BT_revealPW
            // 
            this.BT_revealPW.BackgroundImage = global::MTT_Manager.Properties.Resources.eye_close_1;
            this.BT_revealPW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_revealPW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_revealPW.Location = new System.Drawing.Point(293, 55);
            this.BT_revealPW.Name = "BT_revealPW";
            this.BT_revealPW.Size = new System.Drawing.Size(32, 20);
            this.BT_revealPW.TabIndex = 6;
            this.BT_revealPW.TabStop = false;
            this.BT_revealPW.UseVisualStyleBackColor = true;
            this.BT_revealPW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BT_revealPW_MouseDown);
            this.BT_revealPW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BT_revealPW_MouseUp);
            // 
            // passInput
            // 
            this.passInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.passInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.passInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passInput.Location = new System.Drawing.Point(58, 55);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(236, 20);
            this.passInput.TabIndex = 7;
            // 
            // BT_Close
            // 
            this.BT_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Close.Location = new System.Drawing.Point(215, 88);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(150, 45);
            this.BT_Close.TabIndex = 9;
            this.BT_Close.Text = "Salir";
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // BT_login
            // 
            this.BT_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_login.Location = new System.Drawing.Point(12, 88);
            this.BT_login.Name = "BT_login";
            this.BT_login.Size = new System.Drawing.Size(150, 45);
            this.BT_login.TabIndex = 8;
            this.BT_login.Text = "Ingresar";
            this.BT_login.UseVisualStyleBackColor = true;
            this.BT_login.Click += new System.EventHandler(this.BT_login_Click);
            // 
            // ConfirmWithPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 145);
            this.Controls.Add(this.BT_revealPW);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.BT_Close);
            this.Controls.Add(this.BT_login);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfirmWithPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmation";
            this.Load += new System.EventHandler(this.ConfirmWithPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_revealPW;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.Button BT_Close;
        private System.Windows.Forms.Button BT_login;
    }
}