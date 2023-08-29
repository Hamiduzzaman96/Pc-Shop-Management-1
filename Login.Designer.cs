namespace PC_Shop_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.userNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.passTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.forgetPassButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.infoButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BorderRadius = 20;
            this.loginButton.CheckedState.Parent = this.loginButton;
            this.loginButton.CustomImages.Parent = this.loginButton;
            this.loginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(180)))), ((int)(((byte)(138)))));
            resources.ApplyResources(this.loginButton, "loginButton");
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.HoverState.Parent = this.loginButton;
            this.loginButton.Name = "loginButton";
            this.loginButton.ShadowDecoration.Parent = this.loginButton;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // userNameTb
            // 
            this.userNameTb.Animated = true;
            this.userNameTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.userNameTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.userNameTb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.userNameTb.BorderRadius = 18;
            this.userNameTb.BorderThickness = 2;
            this.userNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTb.DefaultText = "";
            this.userNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userNameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTb.DisabledState.Parent = this.userNameTb;
            this.userNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.userNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(156)))), ((int)(((byte)(252)))));
            this.userNameTb.FocusedState.Parent = this.userNameTb;
            this.userNameTb.ForeColor = System.Drawing.Color.White;
            this.userNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(156)))), ((int)(((byte)(252)))));
            this.userNameTb.HoverState.Parent = this.userNameTb;
            this.userNameTb.IconRightOffset = new System.Drawing.Point(3, 3);
            this.userNameTb.IconRightSize = new System.Drawing.Size(40, 40);
            resources.ApplyResources(this.userNameTb, "userNameTb");
            this.userNameTb.Name = "userNameTb";
            this.userNameTb.PasswordChar = '\0';
            this.userNameTb.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.userNameTb.PlaceholderText = "Username";
            this.userNameTb.SelectedText = "";
            this.userNameTb.ShadowDecoration.Parent = this.userNameTb;
            // 
            // passTb
            // 
            this.passTb.Animated = true;
            this.passTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.passTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.passTb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.passTb.BorderRadius = 18;
            this.passTb.BorderThickness = 2;
            this.passTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTb.DefaultText = "";
            this.passTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTb.DisabledState.Parent = this.passTb;
            this.passTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.passTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(156)))), ((int)(((byte)(252)))));
            this.passTb.FocusedState.Parent = this.passTb;
            this.passTb.ForeColor = System.Drawing.Color.White;
            this.passTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(156)))), ((int)(((byte)(252)))));
            this.passTb.HoverState.Parent = this.passTb;
            this.passTb.IconRightOffset = new System.Drawing.Point(3, 3);
            this.passTb.IconRightSize = new System.Drawing.Size(40, 40);
            resources.ApplyResources(this.passTb, "passTb");
            this.passTb.Name = "passTb";
            this.passTb.PasswordChar = '*';
            this.passTb.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.passTb.PlaceholderText = "Password";
            this.passTb.SelectedText = "";
            this.passTb.ShadowDecoration.Parent = this.passTb;
            this.passTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passTb_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exitButton);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // exitButton
            // 
            this.exitButton.BorderColor = System.Drawing.Color.Transparent;
            this.exitButton.BorderRadius = 15;
            this.exitButton.CheckedState.Parent = this.exitButton;
            this.exitButton.CustomImages.Parent = this.exitButton;
            this.exitButton.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.exitButton.HoverState.Parent = this.exitButton;
            this.exitButton.Image = global::PC_Shop_Management_System.Properties.Resources.white_power_off;
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // forgetPassButton
            // 
            this.forgetPassButton.BorderColor = System.Drawing.Color.Transparent;
            this.forgetPassButton.BorderRadius = 12;
            this.forgetPassButton.CheckedState.Parent = this.forgetPassButton;
            this.forgetPassButton.CustomImages.Parent = this.forgetPassButton;
            this.forgetPassButton.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.forgetPassButton, "forgetPassButton");
            this.forgetPassButton.ForeColor = System.Drawing.Color.White;
            this.forgetPassButton.HoverState.Parent = this.forgetPassButton;
            this.forgetPassButton.Name = "forgetPassButton";
            this.forgetPassButton.ShadowDecoration.Parent = this.forgetPassButton;
            this.forgetPassButton.Click += new System.EventHandler(this.forgetPassButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // infoButton
            // 
            this.infoButton.BorderColor = System.Drawing.Color.Transparent;
            this.infoButton.BorderRadius = 15;
            this.infoButton.CheckedState.Parent = this.infoButton;
            this.infoButton.CustomImages.Parent = this.infoButton;
            this.infoButton.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.infoButton, "infoButton");
            this.infoButton.ForeColor = System.Drawing.Color.White;
            this.infoButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(156)))), ((int)(((byte)(252)))));
            this.infoButton.HoverState.Parent = this.infoButton;
            this.infoButton.Image = global::PC_Shop_Management_System.Properties.Resources.white_info;
            this.infoButton.Name = "infoButton";
            this.infoButton.ShadowDecoration.Parent = this.infoButton;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::PC_Shop_Management_System.Properties.Resources.user_white;
            resources.ApplyResources(this.guna2PictureBox1, "guna2PictureBox1");
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.forgetPassButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.passTb);
            this.Controls.Add(this.userNameTb);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Guna.UI2.WinForms.Guna2TextBox userNameTb;
        private Guna.UI2.WinForms.Guna2TextBox passTb;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button exitButton;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button forgetPassButton;
        private Guna.UI2.WinForms.Guna2Button infoButton;
        private System.Windows.Forms.Label label1;
    }
}

