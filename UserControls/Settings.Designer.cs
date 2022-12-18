namespace Faded_Injector.UserControls
{
    partial class Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BgOptionsPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.Themes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ChooseBg = new Guna.UI2.WinForms.Guna2Button();
            this.ResetBg = new Guna.UI2.WinForms.Guna2Button();
            this.DiscordOptionsPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.UpdateRpc = new Guna.UI2.WinForms.Guna2Button();
            this.State = new Guna.UI2.WinForms.Guna2TextBox();
            this.Detail = new Guna.UI2.WinForms.Guna2TextBox();
            this.Rpc = new Guna.UI2.WinForms.Guna2CheckBox();
            this.DirectoryOptionsPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.AppDir = new Guna.UI2.WinForms.Guna2Button();
            this.DataDir = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.AutoUpdate = new Guna.UI2.WinForms.Guna2CheckBox();
            this.AutoFocus = new Guna.UI2.WinForms.Guna2CheckBox();
            this.BgOptionsPanel.SuspendLayout();
            this.DiscordOptionsPanel.SuspendLayout();
            this.DirectoryOptionsPanel.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BgOptionsPanel
            // 
            this.BgOptionsPanel.BackColor = System.Drawing.Color.Transparent;
            this.BgOptionsPanel.Controls.Add(this.Themes);
            this.BgOptionsPanel.Controls.Add(this.ChooseBg);
            this.BgOptionsPanel.Controls.Add(this.ResetBg);
            this.BgOptionsPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BgOptionsPanel.Location = new System.Drawing.Point(3, 3);
            this.BgOptionsPanel.Name = "BgOptionsPanel";
            this.BgOptionsPanel.Radius = 6;
            this.BgOptionsPanel.ShadowColor = System.Drawing.Color.Black;
            this.BgOptionsPanel.Size = new System.Drawing.Size(270, 190);
            this.BgOptionsPanel.TabIndex = 0;
            // 
            // Themes
            // 
            this.Themes.BackColor = System.Drawing.Color.Transparent;
            this.Themes.BorderColor = System.Drawing.Color.BlueViolet;
            this.Themes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Themes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Themes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Themes.FocusedColor = System.Drawing.Color.DarkMagenta;
            this.Themes.FocusedState.BorderColor = System.Drawing.Color.DarkMagenta;
            this.Themes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Themes.ForeColor = System.Drawing.Color.White;
            this.Themes.ItemHeight = 30;
            this.Themes.Items.AddRange(new object[] {
            "None",
            "FadedProxy",
            "Bigrat",
            "Black"});
            this.Themes.Location = new System.Drawing.Point(65, 77);
            this.Themes.Name = "Themes";
            this.Themes.Size = new System.Drawing.Size(140, 36);
            this.Themes.StartIndex = 0;
            this.Themes.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Themes.TabIndex = 2;
            this.Themes.SelectedIndexChanged += new System.EventHandler(this.Themes_SelectedIndexChanged);
            // 
            // ChooseBg
            // 
            this.ChooseBg.Animated = true;
            this.ChooseBg.BorderRadius = 9;
            this.ChooseBg.BorderThickness = 1;
            this.ChooseBg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ChooseBg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ChooseBg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ChooseBg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ChooseBg.FillColor = System.Drawing.Color.BlueViolet;
            this.ChooseBg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseBg.ForeColor = System.Drawing.Color.White;
            this.ChooseBg.Location = new System.Drawing.Point(56, 36);
            this.ChooseBg.Name = "ChooseBg";
            this.ChooseBg.Size = new System.Drawing.Size(158, 35);
            this.ChooseBg.TabIndex = 1;
            this.ChooseBg.Text = "Choose Wallpaper";
            this.ChooseBg.Click += new System.EventHandler(this.ChooseBg_Click);
            // 
            // ResetBg
            // 
            this.ResetBg.Animated = true;
            this.ResetBg.BorderRadius = 9;
            this.ResetBg.BorderThickness = 1;
            this.ResetBg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ResetBg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ResetBg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ResetBg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ResetBg.FillColor = System.Drawing.Color.BlueViolet;
            this.ResetBg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBg.ForeColor = System.Drawing.Color.White;
            this.ResetBg.Location = new System.Drawing.Point(84, 119);
            this.ResetBg.Name = "ResetBg";
            this.ResetBg.Size = new System.Drawing.Size(103, 35);
            this.ResetBg.TabIndex = 0;
            this.ResetBg.Text = "Reset";
            this.ResetBg.Click += new System.EventHandler(this.ResetBg_Click);
            // 
            // DiscordOptionsPanel
            // 
            this.DiscordOptionsPanel.BackColor = System.Drawing.Color.Transparent;
            this.DiscordOptionsPanel.Controls.Add(this.UpdateRpc);
            this.DiscordOptionsPanel.Controls.Add(this.State);
            this.DiscordOptionsPanel.Controls.Add(this.Detail);
            this.DiscordOptionsPanel.Controls.Add(this.Rpc);
            this.DiscordOptionsPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DiscordOptionsPanel.Location = new System.Drawing.Point(279, 3);
            this.DiscordOptionsPanel.Name = "DiscordOptionsPanel";
            this.DiscordOptionsPanel.Radius = 6;
            this.DiscordOptionsPanel.ShadowColor = System.Drawing.Color.Black;
            this.DiscordOptionsPanel.Size = new System.Drawing.Size(270, 190);
            this.DiscordOptionsPanel.TabIndex = 1;
            // 
            // UpdateRpc
            // 
            this.UpdateRpc.Animated = true;
            this.UpdateRpc.BorderRadius = 9;
            this.UpdateRpc.BorderThickness = 1;
            this.UpdateRpc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateRpc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateRpc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateRpc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateRpc.FillColor = System.Drawing.Color.BlueViolet;
            this.UpdateRpc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.UpdateRpc.ForeColor = System.Drawing.Color.White;
            this.UpdateRpc.Location = new System.Drawing.Point(81, 132);
            this.UpdateRpc.Name = "UpdateRpc";
            this.UpdateRpc.Size = new System.Drawing.Size(108, 35);
            this.UpdateRpc.TabIndex = 3;
            this.UpdateRpc.Text = "Update";
            this.UpdateRpc.Click += new System.EventHandler(this.UpdateRpc_Click);
            // 
            // State
            // 
            this.State.Animated = true;
            this.State.BorderColor = System.Drawing.Color.BlueViolet;
            this.State.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.State.DefaultText = "";
            this.State.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.State.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.State.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.State.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.State.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.State.FocusedState.BorderColor = System.Drawing.Color.DarkMagenta;
            this.State.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.State.ForeColor = System.Drawing.Color.White;
            this.State.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.State.Location = new System.Drawing.Point(37, 90);
            this.State.Name = "State";
            this.State.PasswordChar = '\0';
            this.State.PlaceholderText = "State";
            this.State.SelectedText = "";
            this.State.Size = new System.Drawing.Size(196, 36);
            this.State.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.State.TabIndex = 2;
            // 
            // Detail
            // 
            this.Detail.Animated = true;
            this.Detail.BorderColor = System.Drawing.Color.BlueViolet;
            this.Detail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Detail.DefaultText = "";
            this.Detail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Detail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Detail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Detail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Detail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Detail.FocusedState.BorderColor = System.Drawing.Color.DarkMagenta;
            this.Detail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Detail.ForeColor = System.Drawing.Color.White;
            this.Detail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Detail.Location = new System.Drawing.Point(37, 48);
            this.Detail.Name = "Detail";
            this.Detail.PasswordChar = '\0';
            this.Detail.PlaceholderText = "Detail";
            this.Detail.SelectedText = "";
            this.Detail.Size = new System.Drawing.Size(196, 36);
            this.Detail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Detail.TabIndex = 1;
            // 
            // Rpc
            // 
            this.Rpc.Animated = true;
            this.Rpc.AutoSize = true;
            this.Rpc.CheckedState.BorderColor = System.Drawing.Color.BlueViolet;
            this.Rpc.CheckedState.BorderRadius = 0;
            this.Rpc.CheckedState.BorderThickness = 0;
            this.Rpc.CheckedState.FillColor = System.Drawing.Color.BlueViolet;
            this.Rpc.Location = new System.Drawing.Point(81, 23);
            this.Rpc.Name = "Rpc";
            this.Rpc.Size = new System.Drawing.Size(108, 19);
            this.Rpc.TabIndex = 0;
            this.Rpc.Text = "Discord RPC";
            this.Rpc.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Rpc.UncheckedState.BorderRadius = 0;
            this.Rpc.UncheckedState.BorderThickness = 0;
            this.Rpc.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Rpc.CheckedChanged += new System.EventHandler(this.Rpc_CheckedChanged);
            // 
            // DirectoryOptionsPanel
            // 
            this.DirectoryOptionsPanel.BackColor = System.Drawing.Color.Transparent;
            this.DirectoryOptionsPanel.Controls.Add(this.AppDir);
            this.DirectoryOptionsPanel.Controls.Add(this.DataDir);
            this.DirectoryOptionsPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DirectoryOptionsPanel.Location = new System.Drawing.Point(555, 3);
            this.DirectoryOptionsPanel.Name = "DirectoryOptionsPanel";
            this.DirectoryOptionsPanel.Radius = 6;
            this.DirectoryOptionsPanel.ShadowColor = System.Drawing.Color.Black;
            this.DirectoryOptionsPanel.Size = new System.Drawing.Size(223, 190);
            this.DirectoryOptionsPanel.TabIndex = 2;
            // 
            // AppDir
            // 
            this.AppDir.Animated = true;
            this.AppDir.BorderRadius = 9;
            this.AppDir.BorderThickness = 1;
            this.AppDir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AppDir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AppDir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AppDir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AppDir.FillColor = System.Drawing.Color.BlueViolet;
            this.AppDir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.AppDir.ForeColor = System.Drawing.Color.White;
            this.AppDir.Location = new System.Drawing.Point(32, 64);
            this.AppDir.Name = "AppDir";
            this.AppDir.Size = new System.Drawing.Size(158, 35);
            this.AppDir.TabIndex = 5;
            this.AppDir.Text = "Open App Directory";
            this.AppDir.Click += new System.EventHandler(this.AppDir_Click);
            // 
            // DataDir
            // 
            this.DataDir.Animated = true;
            this.DataDir.BorderRadius = 9;
            this.DataDir.BorderThickness = 1;
            this.DataDir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DataDir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DataDir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DataDir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DataDir.FillColor = System.Drawing.Color.BlueViolet;
            this.DataDir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.DataDir.ForeColor = System.Drawing.Color.White;
            this.DataDir.Location = new System.Drawing.Point(32, 23);
            this.DataDir.Name = "DataDir";
            this.DataDir.Size = new System.Drawing.Size(158, 35);
            this.DataDir.TabIndex = 4;
            this.DataDir.Text = "Open Data Folder";
            this.DataDir.Click += new System.EventHandler(this.DataDir_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.AutoUpdate);
            this.guna2ShadowPanel1.Controls.Add(this.AutoFocus);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(3, 199);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 6;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(228, 93);
            this.guna2ShadowPanel1.TabIndex = 3;
            // 
            // AutoUpdate
            // 
            this.AutoUpdate.Animated = true;
            this.AutoUpdate.AutoSize = true;
            this.AutoUpdate.Checked = true;
            this.AutoUpdate.CheckedState.BorderColor = System.Drawing.Color.BlueViolet;
            this.AutoUpdate.CheckedState.BorderRadius = 0;
            this.AutoUpdate.CheckedState.BorderThickness = 0;
            this.AutoUpdate.CheckedState.FillColor = System.Drawing.Color.BlueViolet;
            this.AutoUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoUpdate.Location = new System.Drawing.Point(33, 49);
            this.AutoUpdate.Name = "AutoUpdate";
            this.AutoUpdate.Size = new System.Drawing.Size(155, 19);
            this.AutoUpdate.TabIndex = 1;
            this.AutoUpdate.Text = "Auto Update Clients";
            this.AutoUpdate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AutoUpdate.UncheckedState.BorderRadius = 0;
            this.AutoUpdate.UncheckedState.BorderThickness = 0;
            this.AutoUpdate.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AutoUpdate.CheckedChanged += new System.EventHandler(this.AutoUpdate_CheckedChanged);
            // 
            // AutoFocus
            // 
            this.AutoFocus.Animated = true;
            this.AutoFocus.AutoSize = true;
            this.AutoFocus.Checked = true;
            this.AutoFocus.CheckedState.BorderColor = System.Drawing.Color.BlueViolet;
            this.AutoFocus.CheckedState.BorderRadius = 0;
            this.AutoFocus.CheckedState.BorderThickness = 0;
            this.AutoFocus.CheckedState.FillColor = System.Drawing.Color.BlueViolet;
            this.AutoFocus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoFocus.Location = new System.Drawing.Point(33, 24);
            this.AutoFocus.Name = "AutoFocus";
            this.AutoFocus.Size = new System.Drawing.Size(163, 19);
            this.AutoFocus.TabIndex = 0;
            this.AutoFocus.Text = "Auto Focus Minecraft";
            this.AutoFocus.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AutoFocus.UncheckedState.BorderRadius = 0;
            this.AutoFocus.UncheckedState.BorderThickness = 0;
            this.AutoFocus.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AutoFocus.CheckedChanged += new System.EventHandler(this.AutoFocus_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.DirectoryOptionsPanel);
            this.Controls.Add(this.DiscordOptionsPanel);
            this.Controls.Add(this.BgOptionsPanel);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(781, 543);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.BgOptionsPanel.ResumeLayout(false);
            this.DiscordOptionsPanel.ResumeLayout(false);
            this.DiscordOptionsPanel.PerformLayout();
            this.DirectoryOptionsPanel.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel BgOptionsPanel;
        private Guna.UI2.WinForms.Guna2Button ResetBg;
        private Guna.UI2.WinForms.Guna2Button ChooseBg;
        private Guna.UI2.WinForms.Guna2ComboBox Themes;
        private Guna.UI2.WinForms.Guna2ShadowPanel DiscordOptionsPanel;
        private Guna.UI2.WinForms.Guna2TextBox Detail;
        private Guna.UI2.WinForms.Guna2CheckBox Rpc;
        private Guna.UI2.WinForms.Guna2TextBox State;
        private Guna.UI2.WinForms.Guna2Button UpdateRpc;
        private Guna.UI2.WinForms.Guna2ShadowPanel DirectoryOptionsPanel;
        private Guna.UI2.WinForms.Guna2Button AppDir;
        private Guna.UI2.WinForms.Guna2Button DataDir;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2CheckBox AutoUpdate;
        private Guna.UI2.WinForms.Guna2CheckBox AutoFocus;
    }
}
