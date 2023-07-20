namespace MTT_Manager
{
    partial class MainFrame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sesion_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.mySplitContainer = new System.Windows.Forms.SplitContainer();
            this.BT_admin = new System.Windows.Forms.Button();
            this.Pic_AccountState = new System.Windows.Forms.PictureBox();
            this.BT_revealPW = new System.Windows.Forms.Button();
            this.BT_DeleteUser = new System.Windows.Forms.Button();
            this.BT_Ban = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LastBanLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LastLoginLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.registerDateLabel = new System.Windows.Forms.Label();
            this.BT_refresh_user = new System.Windows.Forms.Button();
            this.Input_GamesFilter = new System.Windows.Forms.TextBox();
            this.GamesListBox = new System.Windows.Forms.ComboBox();
            this.userRegisterDate = new System.Windows.Forms.Label();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.gameLastScoreLabel = new System.Windows.Forms.Label();
            this.Game_LastScore_date = new System.Windows.Forms.Label();
            this.game_HighScoreLabel = new System.Windows.Forms.Label();
            this.Game_HighScore_date = new System.Windows.Forms.Label();
            this.userNickName = new System.Windows.Forms.Label();
            this.userIDLabel = new System.Windows.Forms.Label();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BT_refresh = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySplitContainer)).BeginInit();
            this.mySplitContainer.Panel1.SuspendLayout();
            this.mySplitContainer.Panel2.SuspendLayout();
            this.mySplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_AccountState)).BeginInit();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesiónToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sesiónToolStripMenuItem
            // 
            this.sesiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_sesion_logout});
            this.sesiónToolStripMenuItem.Name = "sesiónToolStripMenuItem";
            this.sesiónToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sesiónToolStripMenuItem.Text = "Sesión";
            // 
            // menu_sesion_logout
            // 
            this.menu_sesion_logout.Name = "menu_sesion_logout";
            this.menu_sesion_logout.Size = new System.Drawing.Size(142, 22);
            this.menu_sesion_logout.Text = "Cerrar sesión";
            this.menu_sesion_logout.Click += new System.EventHandler(this.menu_sesion_logout_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoUsuarioToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.imprimirReporteToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // nuevoUsuarioToolStripMenuItem
            // 
            this.nuevoUsuarioToolStripMenuItem.Name = "nuevoUsuarioToolStripMenuItem";
            this.nuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoUsuarioToolStripMenuItem.Text = "Nuevo Usuario";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // imprimirReporteToolStripMenuItem
            // 
            this.imprimirReporteToolStripMenuItem.Name = "imprimirReporteToolStripMenuItem";
            this.imprimirReporteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirReporteToolStripMenuItem.Text = "Imprimir reporte";
            this.imprimirReporteToolStripMenuItem.Click += new System.EventHandler(this.imprimirReporteToolStripMenuItem_Click);
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.AllowUserToResizeColumns = false;
            this.dataView.AllowUserToResizeRows = false;
            this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(13, 32);
            this.dataView.MultiSelect = false;
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView.Size = new System.Drawing.Size(542, 382);
            this.dataView.TabIndex = 2;
            this.dataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellClick);
            this.dataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellDoubleClick);
            // 
            // mySplitContainer
            // 
            this.mySplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mySplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mySplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mySplitContainer.IsSplitterFixed = true;
            this.mySplitContainer.Location = new System.Drawing.Point(0, 24);
            this.mySplitContainer.Name = "mySplitContainer";
            // 
            // mySplitContainer.Panel1
            // 
            this.mySplitContainer.Panel1.Controls.Add(this.BT_admin);
            this.mySplitContainer.Panel1.Controls.Add(this.Pic_AccountState);
            this.mySplitContainer.Panel1.Controls.Add(this.BT_revealPW);
            this.mySplitContainer.Panel1.Controls.Add(this.BT_DeleteUser);
            this.mySplitContainer.Panel1.Controls.Add(this.BT_Ban);
            this.mySplitContainer.Panel1.Controls.Add(this.PasswordLabel);
            this.mySplitContainer.Panel1.Controls.Add(this.label12);
            this.mySplitContainer.Panel1.Controls.Add(this.EmailLabel);
            this.mySplitContainer.Panel1.Controls.Add(this.label10);
            this.mySplitContainer.Panel1.Controls.Add(this.LastBanLabel);
            this.mySplitContainer.Panel1.Controls.Add(this.label5);
            this.mySplitContainer.Panel1.Controls.Add(this.LastLoginLabel);
            this.mySplitContainer.Panel1.Controls.Add(this.label1);
            this.mySplitContainer.Panel1.Controls.Add(this.registerDateLabel);
            this.mySplitContainer.Panel1.Controls.Add(this.BT_refresh_user);
            this.mySplitContainer.Panel1.Controls.Add(this.Input_GamesFilter);
            this.mySplitContainer.Panel1.Controls.Add(this.GamesListBox);
            this.mySplitContainer.Panel1.Controls.Add(this.userRegisterDate);
            this.mySplitContainer.Panel1.Controls.Add(this.GamePanel);
            this.mySplitContainer.Panel1.Controls.Add(this.userNickName);
            this.mySplitContainer.Panel1.Controls.Add(this.userIDLabel);
            this.mySplitContainer.Panel1.Controls.Add(this.userPicture);
            // 
            // mySplitContainer.Panel2
            // 
            this.mySplitContainer.Panel2.Controls.Add(this.textBox2);
            this.mySplitContainer.Panel2.Controls.Add(this.BT_refresh);
            this.mySplitContainer.Panel2.Controls.Add(this.dataView);
            this.mySplitContainer.Size = new System.Drawing.Size(800, 426);
            this.mySplitContainer.SplitterDistance = 230;
            this.mySplitContainer.SplitterWidth = 1;
            this.mySplitContainer.TabIndex = 3;
            // 
            // BT_admin
            // 
            this.BT_admin.BackColor = System.Drawing.SystemColors.Control;
            this.BT_admin.BackgroundImage = global::MTT_Manager.Properties.Resources.admin_icon;
            this.BT_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_admin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_admin.Location = new System.Drawing.Point(16, 32);
            this.BT_admin.Name = "BT_admin";
            this.BT_admin.Size = new System.Drawing.Size(35, 35);
            this.BT_admin.TabIndex = 24;
            this.BT_admin.UseVisualStyleBackColor = false;
            this.BT_admin.Click += new System.EventHandler(this.BT_admin_Click);
            this.BT_admin.MouseEnter += new System.EventHandler(this.BT_admin_MouseEnter);
            // 
            // Pic_AccountState
            // 
            this.Pic_AccountState.Image = global::MTT_Manager.Properties.Resources.Verifed_icon;
            this.Pic_AccountState.Location = new System.Drawing.Point(16, 94);
            this.Pic_AccountState.Name = "Pic_AccountState";
            this.Pic_AccountState.Size = new System.Drawing.Size(35, 35);
            this.Pic_AccountState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_AccountState.TabIndex = 23;
            this.Pic_AccountState.TabStop = false;
            this.Pic_AccountState.MouseEnter += new System.EventHandler(this.Pic_AccountState_MouseEnter);
            // 
            // BT_revealPW
            // 
            this.BT_revealPW.BackgroundImage = global::MTT_Manager.Properties.Resources.eye_close_1;
            this.BT_revealPW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_revealPW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_revealPW.Location = new System.Drawing.Point(64, 276);
            this.BT_revealPW.Name = "BT_revealPW";
            this.BT_revealPW.Size = new System.Drawing.Size(18, 13);
            this.BT_revealPW.TabIndex = 1;
            this.BT_revealPW.TabStop = false;
            this.toolTip.SetToolTip(this.BT_revealPW, "Show Password");
            this.BT_revealPW.UseVisualStyleBackColor = true;
            this.BT_revealPW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BT_revealPW_MouseDown);
            this.BT_revealPW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BT_revealPW_MouseUp);
            // 
            // BT_DeleteUser
            // 
            this.BT_DeleteUser.BackColor = System.Drawing.SystemColors.Control;
            this.BT_DeleteUser.BackgroundImage = global::MTT_Manager.Properties.Resources.trashIcon;
            this.BT_DeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_DeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_DeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_DeleteUser.Location = new System.Drawing.Point(179, 94);
            this.BT_DeleteUser.Name = "BT_DeleteUser";
            this.BT_DeleteUser.Size = new System.Drawing.Size(35, 35);
            this.BT_DeleteUser.TabIndex = 22;
            this.toolTip.SetToolTip(this.BT_DeleteUser, "Delete User");
            this.BT_DeleteUser.UseVisualStyleBackColor = false;
            // 
            // BT_Ban
            // 
            this.BT_Ban.BackColor = System.Drawing.SystemColors.Control;
            this.BT_Ban.BackgroundImage = global::MTT_Manager.Properties.Resources.Ban_icon;
            this.BT_Ban.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_Ban.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_Ban.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Ban.Location = new System.Drawing.Point(179, 32);
            this.BT_Ban.Name = "BT_Ban";
            this.BT_Ban.Size = new System.Drawing.Size(35, 35);
            this.BT_Ban.TabIndex = 21;
            this.BT_Ban.UseVisualStyleBackColor = false;
            this.BT_Ban.Click += new System.EventHandler(this.BT_Ban_Click);
            this.BT_Ban.MouseEnter += new System.EventHandler(this.BT_Ban_MouseEnter);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(4, 289);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(214, 15);
            this.PasswordLabel.TabIndex = 20;
            this.PasswordLabel.Text = "My passwords is secure";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(214, 21);
            this.label12.TabIndex = 19;
            this.label12.Text = "Password:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(5, 259);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(214, 26);
            this.EmailLabel.TabIndex = 18;
            this.EmailLabel.Text = "email@truemail.com";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Email:";
            // 
            // LastBanLabel
            // 
            this.LastBanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastBanLabel.Location = new System.Drawing.Point(4, 229);
            this.LastBanLabel.Name = "LastBanLabel";
            this.LastBanLabel.Size = new System.Drawing.Size(214, 26);
            this.LastBanLabel.TabIndex = 16;
            this.LastBanLabel.Text = "[30/03/2002 | 24:04:22] ";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Last Ban:";
            // 
            // LastLoginLabel
            // 
            this.LastLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastLoginLabel.Location = new System.Drawing.Point(4, 198);
            this.LastLoginLabel.Name = "LastLoginLabel";
            this.LastLoginLabel.Size = new System.Drawing.Size(214, 26);
            this.LastLoginLabel.TabIndex = 14;
            this.LastLoginLabel.Text = "[30/03/2002 | 24:04:22] ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Last Login:";
            // 
            // registerDateLabel
            // 
            this.registerDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerDateLabel.Location = new System.Drawing.Point(3, 167);
            this.registerDateLabel.Name = "registerDateLabel";
            this.registerDateLabel.Size = new System.Drawing.Size(214, 26);
            this.registerDateLabel.TabIndex = 12;
            this.registerDateLabel.Text = "[30/03/2002 | 24:04:22] ";
            // 
            // BT_refresh_user
            // 
            this.BT_refresh_user.BackColor = System.Drawing.SystemColors.Control;
            this.BT_refresh_user.BackgroundImage = global::MTT_Manager.Properties.Resources.refresh_icon;
            this.BT_refresh_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_refresh_user.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_refresh_user.Location = new System.Drawing.Point(5, 3);
            this.BT_refresh_user.Name = "BT_refresh_user";
            this.BT_refresh_user.Size = new System.Drawing.Size(23, 24);
            this.BT_refresh_user.TabIndex = 8;
            this.toolTip.SetToolTip(this.BT_refresh_user, "Refresh");
            this.BT_refresh_user.UseVisualStyleBackColor = false;
            this.BT_refresh_user.Click += new System.EventHandler(this.BT_refresh_user_Click);
            // 
            // Input_GamesFilter
            // 
            this.Input_GamesFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Input_GamesFilter.Location = new System.Drawing.Point(144, 305);
            this.Input_GamesFilter.Name = "Input_GamesFilter";
            this.Input_GamesFilter.Size = new System.Drawing.Size(81, 20);
            this.Input_GamesFilter.TabIndex = 7;
            // 
            // GamesListBox
            // 
            this.GamesListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GamesListBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GamesListBox.FormattingEnabled = true;
            this.GamesListBox.Location = new System.Drawing.Point(3, 305);
            this.GamesListBox.Name = "GamesListBox";
            this.GamesListBox.Size = new System.Drawing.Size(135, 21);
            this.GamesListBox.TabIndex = 6;
            this.GamesListBox.SelectedIndexChanged += new System.EventHandler(this.GamesListBox_SelectedIndexChanged);
            // 
            // userRegisterDate
            // 
            this.userRegisterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRegisterDate.Location = new System.Drawing.Point(3, 155);
            this.userRegisterDate.Name = "userRegisterDate";
            this.userRegisterDate.Size = new System.Drawing.Size(214, 21);
            this.userRegisterDate.TabIndex = 4;
            this.userRegisterDate.Text = "Register Date:";
            // 
            // GamePanel
            // 
            this.GamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GamePanel.Controls.Add(this.gameLastScoreLabel);
            this.GamePanel.Controls.Add(this.Game_LastScore_date);
            this.GamePanel.Controls.Add(this.game_HighScoreLabel);
            this.GamePanel.Controls.Add(this.Game_HighScore_date);
            this.GamePanel.Location = new System.Drawing.Point(3, 331);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(222, 90);
            this.GamePanel.TabIndex = 3;
            // 
            // gameLastScoreLabel
            // 
            this.gameLastScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLastScoreLabel.Location = new System.Drawing.Point(1, 38);
            this.gameLastScoreLabel.Name = "gameLastScoreLabel";
            this.gameLastScoreLabel.Size = new System.Drawing.Size(214, 26);
            this.gameLastScoreLabel.TabIndex = 18;
            this.gameLastScoreLabel.Text = "0000000000000";
            // 
            // Game_LastScore_date
            // 
            this.Game_LastScore_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_LastScore_date.Location = new System.Drawing.Point(-1, 26);
            this.Game_LastScore_date.Name = "Game_LastScore_date";
            this.Game_LastScore_date.Size = new System.Drawing.Size(214, 21);
            this.Game_LastScore_date.TabIndex = 19;
            this.Game_LastScore_date.Text = "Last Score: [30/03/2002 | 24:04:22] ";
            // 
            // game_HighScoreLabel
            // 
            this.game_HighScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_HighScoreLabel.Location = new System.Drawing.Point(1, 12);
            this.game_HighScoreLabel.Name = "game_HighScoreLabel";
            this.game_HighScoreLabel.Size = new System.Drawing.Size(214, 26);
            this.game_HighScoreLabel.TabIndex = 17;
            this.game_HighScoreLabel.Text = "0000000000000";
            // 
            // Game_HighScore_date
            // 
            this.Game_HighScore_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_HighScore_date.Location = new System.Drawing.Point(-1, 0);
            this.Game_HighScore_date.Name = "Game_HighScore_date";
            this.Game_HighScore_date.Size = new System.Drawing.Size(214, 21);
            this.Game_HighScore_date.TabIndex = 17;
            this.Game_HighScore_date.Text = "High Score: [30/03/2002 | 24:04:22] ";
            // 
            // userNickName
            // 
            this.userNickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNickName.Location = new System.Drawing.Point(2, 132);
            this.userNickName.Name = "userNickName";
            this.userNickName.Size = new System.Drawing.Size(222, 23);
            this.userNickName.TabIndex = 2;
            this.userNickName.Text = "NickName";
            this.userNickName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userIDLabel
            // 
            this.userIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userIDLabel.Location = new System.Drawing.Point(32, 3);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(193, 23);
            this.userIDLabel.TabIndex = 1;
            this.userIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userPicture
            // 
            this.userPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userPicture.Image = global::MTT_Manager.Properties.Resources.MTT_Logo_;
            this.userPicture.Location = new System.Drawing.Point(66, 29);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(100, 100);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            this.userPicture.DoubleClick += new System.EventHandler(this.userPicture_DoubleClick);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(382, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 4;
            // 
            // BT_refresh
            // 
            this.BT_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_refresh.BackgroundImage = global::MTT_Manager.Properties.Resources.refresh_icon;
            this.BT_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_refresh.Location = new System.Drawing.Point(16, 3);
            this.BT_refresh.Name = "BT_refresh";
            this.BT_refresh.Size = new System.Drawing.Size(23, 23);
            this.BT_refresh.TabIndex = 3;
            this.BT_refresh.UseVisualStyleBackColor = true;
            this.BT_refresh.Click += new System.EventHandler(this.BT_refresh_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mySplitContainer);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrame_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.mySplitContainer.Panel1.ResumeLayout(false);
            this.mySplitContainer.Panel1.PerformLayout();
            this.mySplitContainer.Panel2.ResumeLayout(false);
            this.mySplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mySplitContainer)).EndInit();
            this.mySplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_AccountState)).EndInit();
            this.GamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_sesion_logout;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.SplitContainer mySplitContainer;
        private System.Windows.Forms.Button BT_refresh;
        private System.Windows.Forms.Label userNickName;
        private System.Windows.Forms.Label userIDLabel;
        private System.Windows.Forms.Label userRegisterDate;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.TextBox Input_GamesFilter;
        private System.Windows.Forms.ComboBox GamesListBox;
        private System.Windows.Forms.Button BT_refresh_user;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label registerDateLabel;
        private System.Windows.Forms.Label LastBanLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LastLoginLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label gameLastScoreLabel;
        private System.Windows.Forms.Label Game_LastScore_date;
        private System.Windows.Forms.Label game_HighScoreLabel;
        private System.Windows.Forms.Label Game_HighScore_date;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BT_DeleteUser;
        private System.Windows.Forms.Button BT_Ban;
        private System.Windows.Forms.Button BT_revealPW;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox Pic_AccountState;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirReporteToolStripMenuItem;
        private System.Windows.Forms.Button BT_admin;
    }
}