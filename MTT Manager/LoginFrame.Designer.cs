namespace MTT_Manager
{
    partial class LoginFrame
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrame));
            this.BT_login = new System.Windows.Forms.Button();
            this.BT_Close = new System.Windows.Forms.Button();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.passInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_revealPW = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_login
            // 
            this.BT_login.Location = new System.Drawing.Point(12, 166);
            this.BT_login.Name = "BT_login";
            this.BT_login.Size = new System.Drawing.Size(150, 45);
            this.BT_login.TabIndex = 2;
            this.BT_login.Text = "Ingresar";
            this.BT_login.UseVisualStyleBackColor = true;
            this.BT_login.Click += new System.EventHandler(this.BT_login_Click);
            // 
            // BT_Close
            // 
            this.BT_Close.Location = new System.Drawing.Point(221, 164);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(150, 45);
            this.BT_Close.TabIndex = 3;
            this.BT_Close.Text = "Salir";
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // emailInput
            // 
            this.emailInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.emailInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.emailInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailInput.Location = new System.Drawing.Point(64, 99);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(267, 20);
            this.emailInput.TabIndex = 0;
            this.emailInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.emailInput_KeyDown);
            this.emailInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // passInput
            // 
            this.passInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.passInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.passInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passInput.Location = new System.Drawing.Point(64, 138);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(236, 20);
            this.passInput.TabIndex = 1;
            this.passInput.Click += new System.EventHandler(this.passInput_Click);
            this.passInput.TextChanged += new System.EventHandler(this.passInput_TextChanged);
            this.passInput.Enter += new System.EventHandler(this.passInput_Click);
            this.passInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.emailInput_KeyDown);
            this.passInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contraseña";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Correo Electronico";
            // 
            // BT_revealPW
            // 
            this.BT_revealPW.BackgroundImage = global::MTT_Manager.Properties.Resources.eye_close_1;
            this.BT_revealPW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_revealPW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_revealPW.Location = new System.Drawing.Point(299, 138);
            this.BT_revealPW.Name = "BT_revealPW";
            this.BT_revealPW.Size = new System.Drawing.Size(32, 20);
            this.BT_revealPW.TabIndex = 0;
            this.BT_revealPW.TabStop = false;
            this.BT_revealPW.UseVisualStyleBackColor = true;
            this.BT_revealPW.Click += new System.EventHandler(this.BT_revealPW_Click);
            this.BT_revealPW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BT_revealPW_MouseDown);
            this.BT_revealPW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BT_revealPW_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MTT_Manager.Properties.Resources.MTT_Logo_;
            this.pictureBox1.Location = new System.Drawing.Point(138, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LoginFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 221);
            this.Controls.Add(this.BT_revealPW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.BT_Close);
            this.Controls.Add(this.BT_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.LoginFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_login;
        private System.Windows.Forms.Button BT_Close;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_revealPW;
    }
}

