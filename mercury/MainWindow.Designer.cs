namespace mercury
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.lbStatus = new System.Windows.Forms.Label();
            this.ttMain = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.pnSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbALts = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbvpn = new System.Windows.Forms.Label();
            this.lbRainbow = new System.Windows.Forms.Label();
            this.lbChecking = new System.Windows.Forms.Label();
            this.pnEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbMineclose = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pcFantasma = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pcFantasma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbStatus.Location = new System.Drawing.Point(6, 282);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 20);
            this.lbStatus.TabIndex = 1;
            this.ttMain.SetToolTip(this.lbStatus, "");
            this.ttMain.SetToolTipIcon(this.lbStatus, null);
            this.ttMain.SetToolTipTitle(this.lbStatus, "");
            // 
            // ttMain
            // 
            this.ttMain.Active = true;
            this.ttMain.AlignTextWithTitle = false;
            this.ttMain.AllowAutoClose = false;
            this.ttMain.AllowFading = true;
            this.ttMain.AutoCloseDuration = 5000;
            this.ttMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ttMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ttMain.ClickToShowDisplayControl = false;
            this.ttMain.ConvertNewlinesToBreakTags = true;
            this.ttMain.DisplayControl = null;
            this.ttMain.EntryAnimationSpeed = 350;
            this.ttMain.ExitAnimationSpeed = 200;
            this.ttMain.GenerateAutoCloseDuration = false;
            this.ttMain.IconMargin = 6;
            this.ttMain.InitialDelay = 0;
            this.ttMain.Name = "ttMain";
            this.ttMain.Opacity = 1D;
            this.ttMain.OverrideToolTipTitles = false;
            this.ttMain.Padding = new System.Windows.Forms.Padding(10);
            this.ttMain.ReshowDelay = 100;
            this.ttMain.ShowAlways = true;
            this.ttMain.ShowBorders = false;
            this.ttMain.ShowIcons = true;
            this.ttMain.ShowShadows = true;
            this.ttMain.Tag = null;
            this.ttMain.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttMain.TextForeColor = System.Drawing.SystemColors.Control;
            this.ttMain.TextMargin = 2;
            this.ttMain.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttMain.TitleForeColor = System.Drawing.Color.White;
            this.ttMain.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.ttMain.ToolTipTitle = null;
            this.ttMain.Popup += new System.EventHandler<Bunifu.UI.WinForms.BunifuToolTip.PopupEventArgs>(this.ttMain_Popup);
            // 
            // pnSenha
            // 
            this.pnSenha.BackColor = System.Drawing.Color.White;
            this.pnSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnSenha.Depth = 0;
            this.pnSenha.Hint = "Senha";
            this.pnSenha.Location = new System.Drawing.Point(66, 207);
            this.pnSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnSenha.Name = "pnSenha";
            this.pnSenha.PasswordChar = '\0';
            this.pnSenha.SelectedText = "";
            this.pnSenha.SelectionLength = 0;
            this.pnSenha.SelectionStart = 0;
            this.pnSenha.Size = new System.Drawing.Size(196, 23);
            this.pnSenha.TabIndex = 3;
            this.pnSenha.TabStop = false;
            this.ttMain.SetToolTip(this.pnSenha, "");
            this.ttMain.SetToolTipIcon(this.pnSenha, null);
            this.ttMain.SetToolTipTitle(this.pnSenha, "");
            this.pnSenha.UseSystemPasswordChar = true;
            this.pnSenha.Click += new System.EventHandler(this.txtPin_Click);
            // 
            // lbALts
            // 
            this.lbALts.AutoSize = true;
            this.lbALts.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbALts.Location = new System.Drawing.Point(0, 0);
            this.lbALts.Name = "lbALts";
            this.lbALts.Size = new System.Drawing.Size(154, 19);
            this.lbALts.TabIndex = 19;
            this.lbALts.Text = "Alts: nick1, nick2, nick3";
            this.ttMain.SetToolTip(this.lbALts, "");
            this.ttMain.SetToolTipIcon(this.lbALts, null);
            this.ttMain.SetToolTipTitle(this.lbALts, "");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(0)))), ((int)(((byte)(250)))));
            this.panel2.Location = new System.Drawing.Point(-15, -19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(22, 139);
            this.panel2.TabIndex = 7;
            this.ttMain.SetToolTip(this.panel2, "");
            this.ttMain.SetToolTipIcon(this.panel2, null);
            this.ttMain.SetToolTipTitle(this.panel2, "");
            // 
            // lbvpn
            // 
            this.lbvpn.AutoSize = true;
            this.lbvpn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbvpn.Location = new System.Drawing.Point(0, 0);
            this.lbvpn.Name = "lbvpn";
            this.lbvpn.Size = new System.Drawing.Size(109, 19);
            this.lbvpn.TabIndex = 20;
            this.lbvpn.Text = "VPN: Not found";
            this.ttMain.SetToolTip(this.lbvpn, "");
            this.ttMain.SetToolTipIcon(this.lbvpn, null);
            this.ttMain.SetToolTipTitle(this.lbvpn, "");
            // 
            // lbRainbow
            // 
            this.lbRainbow.AutoSize = true;
            this.lbRainbow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbRainbow.Location = new System.Drawing.Point(274, 284);
            this.lbRainbow.Name = "lbRainbow";
            this.lbRainbow.Size = new System.Drawing.Size(144, 21);
            this.lbRainbow.TabIndex = 38;
            this.lbRainbow.Text = "Mercury Login v0.1";
            this.ttMain.SetToolTip(this.lbRainbow, "");
            this.ttMain.SetToolTipIcon(this.lbRainbow, null);
            this.ttMain.SetToolTipTitle(this.lbRainbow, "");
            this.lbRainbow.Click += new System.EventHandler(this.lbRainbow_Click);
            // 
            // lbChecking
            // 
            this.lbChecking.AutoSize = true;
            this.lbChecking.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChecking.Location = new System.Drawing.Point(9, 277);
            this.lbChecking.Name = "lbChecking";
            this.lbChecking.Size = new System.Drawing.Size(0, 20);
            this.lbChecking.TabIndex = 41;
            this.ttMain.SetToolTip(this.lbChecking, "");
            this.ttMain.SetToolTipIcon(this.lbChecking, null);
            this.ttMain.SetToolTipTitle(this.lbChecking, "");
            // 
            // pnEmail
            // 
            this.pnEmail.BackColor = System.Drawing.Color.White;
            this.pnEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnEmail.Depth = 0;
            this.pnEmail.Hint = "Email";
            this.pnEmail.Location = new System.Drawing.Point(66, 133);
            this.pnEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnEmail.Name = "pnEmail";
            this.pnEmail.PasswordChar = '\0';
            this.pnEmail.SelectedText = "";
            this.pnEmail.SelectionLength = 0;
            this.pnEmail.SelectionStart = 0;
            this.pnEmail.Size = new System.Drawing.Size(196, 23);
            this.pnEmail.TabIndex = 42;
            this.pnEmail.TabStop = false;
            this.ttMain.SetToolTip(this.pnEmail, "");
            this.ttMain.SetToolTipIcon(this.pnEmail, null);
            this.ttMain.SetToolTipTitle(this.pnEmail, "");
            this.pnEmail.UseSystemPasswordChar = false;
            this.pnEmail.Click += new System.EventHandler(this.pnEmail_Click);
            // 
            // lbMineclose
            // 
            this.lbMineclose.AutoSize = true;
            this.lbMineclose.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbMineclose.ForeColor = System.Drawing.Color.DimGray;
            this.lbMineclose.Location = new System.Drawing.Point(620, 81);
            this.lbMineclose.Name = "lbMineclose";
            this.lbMineclose.Size = new System.Drawing.Size(130, 21);
            this.lbMineclose.TabIndex = 36;
            this.lbMineclose.Text = "Minecraft is close";
            this.ttMain.SetToolTip(this.lbMineclose, "");
            this.ttMain.SetToolTipIcon(this.lbMineclose, null);
            this.ttMain.SetToolTipTitle(this.lbMineclose, "");
            this.lbMineclose.Click += new System.EventHandler(this.lbMineclose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "X";
            this.ttMain.SetToolTip(this.label5, "");
            this.ttMain.SetToolTipIcon(this.label5, null);
            this.ttMain.SetToolTipTitle(this.label5, "");
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pcFantasma
            // 
            this.pcFantasma.Image = global::mercury.Properties.Resources.Logo___ffffff;
            this.pcFantasma.Location = new System.Drawing.Point(158, 14);
            this.pcFantasma.Name = "pcFantasma";
            this.pcFantasma.Size = new System.Drawing.Size(100, 93);
            this.pcFantasma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcFantasma.TabIndex = 29;
            this.pcFantasma.TabStop = false;
            this.ttMain.SetToolTip(this.pcFantasma, "");
            this.ttMain.SetToolTipIcon(this.pcFantasma, null);
            this.ttMain.SetToolTipTitle(this.pcFantasma, "");
            this.pcFantasma.Click += new System.EventHandler(this.pcFantasma_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(67, 176);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            this.ttMain.SetToolTip(this.pictureBox3, "");
            this.ttMain.SetToolTipIcon(this.pictureBox3, null);
            this.ttMain.SetToolTipTitle(this.pictureBox3, "");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(62, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.ttMain.SetToolTip(this.pictureBox2, "");
            this.ttMain.SetToolTipIcon(this.pictureBox2, null);
            this.ttMain.SetToolTipTitle(this.pictureBox2, "");
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.ButtonTextMarginLeft = 0;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledBorderColor = System.Drawing.Color.Purple;
            this.btnLogin.DisabledFillColor = System.Drawing.Color.Purple;
            this.btnLogin.DisabledForecolor = System.Drawing.Color.Gray;
            this.btnLogin.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.IconPadding = 10;
            this.btnLogin.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnLogin.IdleBorderRadius = 30;
            this.btnLogin.IdleBorderThickness = 3;
            this.btnLogin.IdleFillColor = System.Drawing.Color.Purple;
            this.btnLogin.IdleIconLeftImage = null;
            this.btnLogin.IdleIconRightImage = null;
            this.btnLogin.Location = new System.Drawing.Point(268, 155);
            this.btnLogin.Name = "btnLogin";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            stateProperties1.BorderRadius = 2;
            stateProperties1.BorderThickness = 3;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnLogin.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            stateProperties2.BorderRadius = 2;
            stateProperties2.BorderThickness = 3;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnLogin.OnPressedState = stateProperties2;
            this.btnLogin.Size = new System.Drawing.Size(87, 44);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttMain.SetToolTip(this.btnLogin, "");
            this.ttMain.SetToolTipIcon(this.btnLogin, null);
            this.ttMain.SetToolTipTitle(this.btnLogin, "");
            this.btnLogin.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // timerCheck
            // 
            this.timerCheck.Enabled = true;
            this.timerCheck.Interval = 13500;
            this.timerCheck.Tick += new System.EventHandler(this.TimerCheck_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(416, 307);
            this.ControlBox = false;
            this.Controls.Add(this.pcFantasma);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnSenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnEmail);
            this.Controls.Add(this.lbChecking);
            this.Controls.Add(this.lbRainbow);
            this.Controls.Add(this.lbMineclose);
            this.Controls.Add(this.lbStatus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcFantasma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbStatus;
        private Bunifu.UI.WinForms.BunifuToolTip ttMain;
        private System.Windows.Forms.Timer timerCheck;
        private MaterialSkin.Controls.MaterialSingleLineTextField pnSenha;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbALts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnEye;
        private System.Windows.Forms.Label lbvpn;
        private System.Windows.Forms.Label lbRainbow;
        private System.Windows.Forms.Label lbChecking;
        private MaterialSkin.Controls.MaterialSingleLineTextField pnEmail;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogin;
        private System.Windows.Forms.Label lbMineclose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pcFantasma;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

