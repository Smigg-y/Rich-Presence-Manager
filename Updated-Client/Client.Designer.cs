
namespace Updated_Client
{
    internal sealed partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.WindowLbl = new MaterialSkin.Controls.MaterialLabel();
            this.TabController = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TimestampOn = new MaterialSkin.Controls.MaterialCheckBox();
            this.StartBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SImageText_Box = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SImageKey_Box = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LImageText_Box = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LImageKey_Box = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.State_Box = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Details_Box = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ClientID_Box = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.InfoTextbox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.KillClientBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LoadFile_Btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SaveFile_Btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.YellowThemeBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BlueThemeBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DarkThemeBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RedThemeBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.GreenThemeBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.PurpleThemeBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.cancerLbl1 = new MaterialSkin.Controls.MaterialLabel();
            this.cancerLbl2 = new MaterialSkin.Controls.MaterialLabel();
            this.TabController.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // WindowLbl
            // 
            this.WindowLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WindowLbl.Depth = 0;
            this.WindowLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.WindowLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WindowLbl.Location = new System.Drawing.Point(2, 2);
            this.WindowLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.WindowLbl.Name = "WindowLbl";
            this.WindowLbl.Size = new System.Drawing.Size(225, 19);
            this.WindowLbl.TabIndex = 0;
            this.WindowLbl.Text = "Rich Presence Manager";
            this.WindowLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowLbl_MouseDown);
            // 
            // TabController
            // 
            this.TabController.Controls.Add(this.tabPage1);
            this.TabController.Controls.Add(this.tabPage2);
            this.TabController.Controls.Add(this.tabPage3);
            this.TabController.Depth = 0;
            this.TabController.Location = new System.Drawing.Point(2, 64);
            this.TabController.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabController.Name = "TabController";
            this.TabController.SelectedIndex = 0;
            this.TabController.Size = new System.Drawing.Size(338, 316);
            this.TabController.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.TimestampOn);
            this.tabPage1.Controls.Add(this.StartBtn);
            this.tabPage1.Controls.Add(this.SImageText_Box);
            this.tabPage1.Controls.Add(this.SImageKey_Box);
            this.tabPage1.Controls.Add(this.LImageText_Box);
            this.tabPage1.Controls.Add(this.LImageKey_Box);
            this.tabPage1.Controls.Add(this.State_Box);
            this.tabPage1.Controls.Add(this.Details_Box);
            this.tabPage1.Controls.Add(this.ClientID_Box);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(330, 290);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // TimestampOn
            // 
            this.TimestampOn.Depth = 0;
            this.TimestampOn.Font = new System.Drawing.Font("Roboto", 10F);
            this.TimestampOn.Location = new System.Drawing.Point(119, 244);
            this.TimestampOn.Margin = new System.Windows.Forms.Padding(0);
            this.TimestampOn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.TimestampOn.MouseState = MaterialSkin.MouseState.HOVER;
            this.TimestampOn.Name = "TimestampOn";
            this.TimestampOn.Ripple = true;
            this.TimestampOn.Size = new System.Drawing.Size(95, 20);
            this.TimestampOn.TabIndex = 12;
            this.TimestampOn.Text = "Timestamp";
            this.TimestampOn.UseVisualStyleBackColor = true;
            // 
            // StartBtn
            // 
            this.StartBtn.AutoSize = true;
            this.StartBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartBtn.Depth = 0;
            this.StartBtn.Icon = null;
            this.StartBtn.Location = new System.Drawing.Point(110, 274);
            this.StartBtn.MinimumSize = new System.Drawing.Size(100, 36);
            this.StartBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Primary = true;
            this.StartBtn.Size = new System.Drawing.Size(113, 36);
            this.StartBtn.TabIndex = 11;
            this.StartBtn.Text = "Start Client";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.SizeChanged += new System.EventHandler(this.StartBtn_SizeChanged);
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // SImageText_Box
            // 
            this.SImageText_Box.Depth = 0;
            this.SImageText_Box.Hint = "Small Image Text";
            this.SImageText_Box.Location = new System.Drawing.Point(41, 210);
            this.SImageText_Box.MaxLength = 32767;
            this.SImageText_Box.MouseState = MaterialSkin.MouseState.HOVER;
            this.SImageText_Box.Name = "SImageText_Box";
            this.SImageText_Box.PasswordChar = '\0';
            this.SImageText_Box.SelectedText = "";
            this.SImageText_Box.SelectionLength = 0;
            this.SImageText_Box.SelectionStart = 0;
            this.SImageText_Box.Size = new System.Drawing.Size(250, 23);
            this.SImageText_Box.TabIndex = 8;
            this.SImageText_Box.TabStop = false;
            this.SImageText_Box.UseSystemPasswordChar = false;
            // 
            // SImageKey_Box
            // 
            this.SImageKey_Box.Depth = 0;
            this.SImageKey_Box.Hint = "Small Image Key";
            this.SImageKey_Box.Location = new System.Drawing.Point(41, 181);
            this.SImageKey_Box.MaxLength = 32767;
            this.SImageKey_Box.MouseState = MaterialSkin.MouseState.HOVER;
            this.SImageKey_Box.Name = "SImageKey_Box";
            this.SImageKey_Box.PasswordChar = '\0';
            this.SImageKey_Box.SelectedText = "";
            this.SImageKey_Box.SelectionLength = 0;
            this.SImageKey_Box.SelectionStart = 0;
            this.SImageKey_Box.Size = new System.Drawing.Size(250, 23);
            this.SImageKey_Box.TabIndex = 7;
            this.SImageKey_Box.TabStop = false;
            this.SImageKey_Box.UseSystemPasswordChar = false;
            // 
            // LImageText_Box
            // 
            this.LImageText_Box.Depth = 0;
            this.LImageText_Box.Hint = "Large Image Text";
            this.LImageText_Box.Location = new System.Drawing.Point(41, 142);
            this.LImageText_Box.MaxLength = 32767;
            this.LImageText_Box.MouseState = MaterialSkin.MouseState.HOVER;
            this.LImageText_Box.Name = "LImageText_Box";
            this.LImageText_Box.PasswordChar = '\0';
            this.LImageText_Box.SelectedText = "";
            this.LImageText_Box.SelectionLength = 0;
            this.LImageText_Box.SelectionStart = 0;
            this.LImageText_Box.Size = new System.Drawing.Size(250, 23);
            this.LImageText_Box.TabIndex = 6;
            this.LImageText_Box.TabStop = false;
            this.LImageText_Box.UseSystemPasswordChar = false;
            // 
            // LImageKey_Box
            // 
            this.LImageKey_Box.Depth = 0;
            this.LImageKey_Box.Hint = "Large Image Key";
            this.LImageKey_Box.Location = new System.Drawing.Point(41, 113);
            this.LImageKey_Box.MaxLength = 32767;
            this.LImageKey_Box.MouseState = MaterialSkin.MouseState.HOVER;
            this.LImageKey_Box.Name = "LImageKey_Box";
            this.LImageKey_Box.PasswordChar = '\0';
            this.LImageKey_Box.SelectedText = "";
            this.LImageKey_Box.SelectionLength = 0;
            this.LImageKey_Box.SelectionStart = 0;
            this.LImageKey_Box.Size = new System.Drawing.Size(250, 23);
            this.LImageKey_Box.TabIndex = 5;
            this.LImageKey_Box.TabStop = false;
            this.LImageKey_Box.UseSystemPasswordChar = false;
            // 
            // State_Box
            // 
            this.State_Box.Depth = 0;
            this.State_Box.Hint = "State";
            this.State_Box.Location = new System.Drawing.Point(41, 74);
            this.State_Box.MaxLength = 32767;
            this.State_Box.MouseState = MaterialSkin.MouseState.HOVER;
            this.State_Box.Name = "State_Box";
            this.State_Box.PasswordChar = '\0';
            this.State_Box.SelectedText = "";
            this.State_Box.SelectionLength = 0;
            this.State_Box.SelectionStart = 0;
            this.State_Box.Size = new System.Drawing.Size(250, 23);
            this.State_Box.TabIndex = 4;
            this.State_Box.TabStop = false;
            this.State_Box.UseSystemPasswordChar = false;
            // 
            // Details_Box
            // 
            this.Details_Box.Depth = 0;
            this.Details_Box.Hint = "Details";
            this.Details_Box.Location = new System.Drawing.Point(41, 45);
            this.Details_Box.MaxLength = 32767;
            this.Details_Box.MouseState = MaterialSkin.MouseState.HOVER;
            this.Details_Box.Name = "Details_Box";
            this.Details_Box.PasswordChar = '\0';
            this.Details_Box.SelectedText = "";
            this.Details_Box.SelectionLength = 0;
            this.Details_Box.SelectionStart = 0;
            this.Details_Box.Size = new System.Drawing.Size(250, 23);
            this.Details_Box.TabIndex = 3;
            this.Details_Box.TabStop = false;
            this.Details_Box.UseSystemPasswordChar = false;
            // 
            // ClientID_Box
            // 
            this.ClientID_Box.Depth = 0;
            this.ClientID_Box.Hint = "Client ID";
            this.ClientID_Box.Location = new System.Drawing.Point(41, 6);
            this.ClientID_Box.MaxLength = 32767;
            this.ClientID_Box.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClientID_Box.Name = "ClientID_Box";
            this.ClientID_Box.PasswordChar = '\0';
            this.ClientID_Box.SelectedText = "";
            this.ClientID_Box.SelectionLength = 0;
            this.ClientID_Box.SelectionStart = 0;
            this.ClientID_Box.Size = new System.Drawing.Size(250, 23);
            this.ClientID_Box.TabIndex = 2;
            this.ClientID_Box.TabStop = false;
            this.ClientID_Box.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.InfoTextbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(330, 290);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Information";
            // 
            // InfoTextbox
            // 
            this.InfoTextbox.AcceptsReturn = true;
            this.InfoTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.InfoTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoTextbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.InfoTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoTextbox.ForeColor = System.Drawing.Color.White;
            this.InfoTextbox.Location = new System.Drawing.Point(3, 3);
            this.InfoTextbox.Multiline = true;
            this.InfoTextbox.Name = "InfoTextbox";
            this.InfoTextbox.ReadOnly = true;
            this.InfoTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InfoTextbox.Size = new System.Drawing.Size(324, 284);
            this.InfoTextbox.TabIndex = 0;
            this.InfoTextbox.WordWrap = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage3.Controls.Add(this.cancerLbl2);
            this.tabPage3.Controls.Add(this.cancerLbl1);
            this.tabPage3.Controls.Add(this.KillClientBtn);
            this.tabPage3.Controls.Add(this.LoadFile_Btn);
            this.tabPage3.Controls.Add(this.SaveFile_Btn);
            this.tabPage3.Controls.Add(this.YellowThemeBtn);
            this.tabPage3.Controls.Add(this.BlueThemeBtn);
            this.tabPage3.Controls.Add(this.DarkThemeBtn);
            this.tabPage3.Controls.Add(this.RedThemeBtn);
            this.tabPage3.Controls.Add(this.GreenThemeBtn);
            this.tabPage3.Controls.Add(this.PurpleThemeBtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(330, 290);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Options";
            // 
            // KillClientBtn
            // 
            this.KillClientBtn.AutoSize = true;
            this.KillClientBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.KillClientBtn.Depth = 0;
            this.KillClientBtn.Icon = null;
            this.KillClientBtn.Location = new System.Drawing.Point(120, 152);
            this.KillClientBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.KillClientBtn.Name = "KillClientBtn";
            this.KillClientBtn.Primary = true;
            this.KillClientBtn.Size = new System.Drawing.Size(98, 36);
            this.KillClientBtn.TabIndex = 8;
            this.KillClientBtn.Text = "Kill Client";
            this.KillClientBtn.UseVisualStyleBackColor = true;
            this.KillClientBtn.Click += new System.EventHandler(this.KillClientBtn_Click);
            // 
            // LoadFile_Btn
            // 
            this.LoadFile_Btn.AutoSize = true;
            this.LoadFile_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadFile_Btn.Depth = 0;
            this.LoadFile_Btn.Icon = null;
            this.LoadFile_Btn.Location = new System.Drawing.Point(170, 100);
            this.LoadFile_Btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoadFile_Btn.Name = "LoadFile_Btn";
            this.LoadFile_Btn.Primary = true;
            this.LoadFile_Btn.Size = new System.Drawing.Size(117, 36);
            this.LoadFile_Btn.TabIndex = 7;
            this.LoadFile_Btn.Text = "Load Options";
            this.LoadFile_Btn.UseVisualStyleBackColor = true;
            this.LoadFile_Btn.Click += new System.EventHandler(this.LoadFile_Btn_Click);
            // 
            // SaveFile_Btn
            // 
            this.SaveFile_Btn.AutoSize = true;
            this.SaveFile_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveFile_Btn.Depth = 0;
            this.SaveFile_Btn.Icon = null;
            this.SaveFile_Btn.Location = new System.Drawing.Point(53, 100);
            this.SaveFile_Btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveFile_Btn.Name = "SaveFile_Btn";
            this.SaveFile_Btn.Primary = true;
            this.SaveFile_Btn.Size = new System.Drawing.Size(116, 36);
            this.SaveFile_Btn.TabIndex = 6;
            this.SaveFile_Btn.Text = "Save Options";
            this.SaveFile_Btn.UseVisualStyleBackColor = true;
            this.SaveFile_Btn.Click += new System.EventHandler(this.SaveFile_Btn_Click);
            // 
            // YellowThemeBtn
            // 
            this.YellowThemeBtn.AutoSize = true;
            this.YellowThemeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.YellowThemeBtn.Depth = 0;
            this.YellowThemeBtn.Icon = null;
            this.YellowThemeBtn.Location = new System.Drawing.Point(126, 48);
            this.YellowThemeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.YellowThemeBtn.Name = "YellowThemeBtn";
            this.YellowThemeBtn.Primary = true;
            this.YellowThemeBtn.Size = new System.Drawing.Size(105, 36);
            this.YellowThemeBtn.TabIndex = 5;
            this.YellowThemeBtn.Text = "Gold Theme";
            this.YellowThemeBtn.UseVisualStyleBackColor = true;
            this.YellowThemeBtn.Click += new System.EventHandler(this.YellowThemeBtn_Click);
            // 
            // BlueThemeBtn
            // 
            this.BlueThemeBtn.AutoSize = true;
            this.BlueThemeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BlueThemeBtn.Depth = 0;
            this.BlueThemeBtn.Icon = null;
            this.BlueThemeBtn.Location = new System.Drawing.Point(124, 6);
            this.BlueThemeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.BlueThemeBtn.Name = "BlueThemeBtn";
            this.BlueThemeBtn.Primary = true;
            this.BlueThemeBtn.Size = new System.Drawing.Size(103, 36);
            this.BlueThemeBtn.TabIndex = 4;
            this.BlueThemeBtn.Text = "Blue Theme";
            this.BlueThemeBtn.UseVisualStyleBackColor = true;
            this.BlueThemeBtn.Click += new System.EventHandler(this.BlueThemeBtn_Click);
            // 
            // DarkThemeBtn
            // 
            this.DarkThemeBtn.AutoSize = true;
            this.DarkThemeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DarkThemeBtn.Depth = 0;
            this.DarkThemeBtn.Icon = null;
            this.DarkThemeBtn.Location = new System.Drawing.Point(228, 6);
            this.DarkThemeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.DarkThemeBtn.Name = "DarkThemeBtn";
            this.DarkThemeBtn.Primary = true;
            this.DarkThemeBtn.Size = new System.Drawing.Size(105, 36);
            this.DarkThemeBtn.TabIndex = 3;
            this.DarkThemeBtn.Text = "Gray Theme";
            this.DarkThemeBtn.UseVisualStyleBackColor = true;
            this.DarkThemeBtn.Click += new System.EventHandler(this.DarkThemeBtn_Click);
            // 
            // RedThemeBtn
            // 
            this.RedThemeBtn.AutoSize = true;
            this.RedThemeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RedThemeBtn.Depth = 0;
            this.RedThemeBtn.Icon = null;
            this.RedThemeBtn.Location = new System.Drawing.Point(232, 48);
            this.RedThemeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.RedThemeBtn.Name = "RedThemeBtn";
            this.RedThemeBtn.Primary = true;
            this.RedThemeBtn.Size = new System.Drawing.Size(95, 36);
            this.RedThemeBtn.TabIndex = 2;
            this.RedThemeBtn.Text = "Red Theme";
            this.RedThemeBtn.UseVisualStyleBackColor = true;
            this.RedThemeBtn.Click += new System.EventHandler(this.RedThemeBtn_Click);
            // 
            // GreenThemeBtn
            // 
            this.GreenThemeBtn.AutoSize = true;
            this.GreenThemeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GreenThemeBtn.Depth = 0;
            this.GreenThemeBtn.Icon = null;
            this.GreenThemeBtn.Location = new System.Drawing.Point(12, 48);
            this.GreenThemeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.GreenThemeBtn.Name = "GreenThemeBtn";
            this.GreenThemeBtn.Primary = true;
            this.GreenThemeBtn.Size = new System.Drawing.Size(113, 36);
            this.GreenThemeBtn.TabIndex = 1;
            this.GreenThemeBtn.Text = "Green Theme";
            this.GreenThemeBtn.UseVisualStyleBackColor = true;
            this.GreenThemeBtn.Click += new System.EventHandler(this.GreenThemeBtn_Click);
            // 
            // PurpleThemeBtn
            // 
            this.PurpleThemeBtn.AutoSize = true;
            this.PurpleThemeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PurpleThemeBtn.Depth = 0;
            this.PurpleThemeBtn.Icon = null;
            this.PurpleThemeBtn.Location = new System.Drawing.Point(3, 6);
            this.PurpleThemeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.PurpleThemeBtn.Name = "PurpleThemeBtn";
            this.PurpleThemeBtn.Primary = true;
            this.PurpleThemeBtn.Size = new System.Drawing.Size(120, 36);
            this.PurpleThemeBtn.TabIndex = 0;
            this.PurpleThemeBtn.Text = "Purple Theme";
            this.PurpleThemeBtn.UseVisualStyleBackColor = true;
            this.PurpleThemeBtn.Click += new System.EventHandler(this.PurpleThemeBtn_Click);
            // 
            // TabSelector
            // 
            this.TabSelector.BaseTabControl = this.TabController;
            this.TabSelector.Depth = 0;
            this.TabSelector.Location = new System.Drawing.Point(0, 24);
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Size = new System.Drawing.Size(340, 40);
            this.TabSelector.TabIndex = 0;
            this.TabSelector.Text = "TabSelection";
            // 
            // Notify
            // 
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Text = "Rich Presence Manager";
            this.Notify.Visible = true;
            this.Notify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Notify_MouseDoubleClick);
            // 
            // Timer
            // 
            this.Timer.Interval = 20;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // cancerLbl1
            // 
            this.cancerLbl1.AutoSize = true;
            this.cancerLbl1.Depth = 0;
            this.cancerLbl1.Font = new System.Drawing.Font("Roboto", 11F);
            this.cancerLbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancerLbl1.Location = new System.Drawing.Point(3, 291);
            this.cancerLbl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancerLbl1.Name = "cancerLbl1";
            this.cancerLbl1.Size = new System.Drawing.Size(331, 19);
            this.cancerLbl1.TabIndex = 9;
            this.cancerLbl1.Text = "You can contact me on Discord at Smiggy#3907";
            // 
            // cancerLbl2
            // 
            this.cancerLbl2.AutoSize = true;
            this.cancerLbl2.Depth = 0;
            this.cancerLbl2.Font = new System.Drawing.Font("Roboto", 11F);
            this.cancerLbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancerLbl2.Location = new System.Drawing.Point(109, 273);
            this.cancerLbl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancerLbl2.Name = "cancerLbl2";
            this.cancerLbl2.Size = new System.Drawing.Size(118, 19);
            this.cancerLbl2.TabIndex = 10;
            this.cancerLbl2.Text = "Made by Smiggy";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 380);
            this.Controls.Add(this.TabSelector);
            this.Controls.Add(this.TabController);
            this.Controls.Add(this.WindowLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Client";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rich Presence Manager";
            this.Resize += new System.EventHandler(this.Client_Resize);
            this.TabController.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel WindowLbl;
        private MaterialSkin.Controls.MaterialTabControl TabController;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector TabSelector;
        private MaterialSkin.Controls.MaterialSingleLineTextField ClientID_Box;
        private MaterialSkin.Controls.MaterialSingleLineTextField Details_Box;
        private MaterialSkin.Controls.MaterialSingleLineTextField SImageText_Box;
        private MaterialSkin.Controls.MaterialSingleLineTextField SImageKey_Box;
        private MaterialSkin.Controls.MaterialSingleLineTextField LImageText_Box;
        private MaterialSkin.Controls.MaterialSingleLineTextField LImageKey_Box;
        private MaterialSkin.Controls.MaterialSingleLineTextField State_Box;
        private System.Windows.Forms.NotifyIcon Notify;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialRaisedButton StartBtn;
        private MaterialSkin.Controls.MaterialCheckBox TimestampOn;
        private MaterialSkin.Controls.MaterialRaisedButton RedThemeBtn;
        private MaterialSkin.Controls.MaterialRaisedButton GreenThemeBtn;
        private MaterialSkin.Controls.MaterialRaisedButton DarkThemeBtn;
        private MaterialSkin.Controls.MaterialRaisedButton PurpleThemeBtn;
        private System.Windows.Forms.TextBox InfoTextbox;
        private MaterialSkin.Controls.MaterialRaisedButton BlueThemeBtn;
        private System.Windows.Forms.Timer Timer;
        private MaterialSkin.Controls.MaterialRaisedButton YellowThemeBtn;
        private MaterialSkin.Controls.MaterialRaisedButton LoadFile_Btn;
        private MaterialSkin.Controls.MaterialRaisedButton SaveFile_Btn;
        private MaterialSkin.Controls.MaterialRaisedButton KillClientBtn;
        private MaterialSkin.Controls.MaterialLabel cancerLbl1;
        private MaterialSkin.Controls.MaterialLabel cancerLbl2;
    }
}

