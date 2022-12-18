namespace Faded_Injector.UserControls
{
    partial class Spoofer
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
            this.BgSpoofPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.Spoof = new Guna.UI2.WinForms.Guna2Button();
            this.Version = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SupportedVersionLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.VersionShadow = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.BgSpoofPanel.SuspendLayout();
            this.VersionShadow.SuspendLayout();
            this.SuspendLayout();
            // 
            // BgSpoofPanel
            // 
            this.BgSpoofPanel.BackColor = System.Drawing.Color.Transparent;
            this.BgSpoofPanel.Controls.Add(this.Spoof);
            this.BgSpoofPanel.Controls.Add(this.Version);
            this.BgSpoofPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BgSpoofPanel.Location = new System.Drawing.Point(208, 176);
            this.BgSpoofPanel.Name = "BgSpoofPanel";
            this.BgSpoofPanel.Radius = 6;
            this.BgSpoofPanel.ShadowColor = System.Drawing.Color.Black;
            this.BgSpoofPanel.Size = new System.Drawing.Size(364, 190);
            this.BgSpoofPanel.TabIndex = 5;
            // 
            // Spoof
            // 
            this.Spoof.Animated = true;
            this.Spoof.BorderRadius = 12;
            this.Spoof.BorderThickness = 1;
            this.Spoof.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Spoof.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Spoof.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Spoof.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Spoof.FillColor = System.Drawing.Color.BlueViolet;
            this.Spoof.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spoof.ForeColor = System.Drawing.Color.White;
            this.Spoof.Location = new System.Drawing.Point(67, 47);
            this.Spoof.Name = "Spoof";
            this.Spoof.Size = new System.Drawing.Size(231, 64);
            this.Spoof.TabIndex = 1;
            this.Spoof.Text = "Spoof";
            this.Spoof.Click += new System.EventHandler(this.Spoof_Click);
            // 
            // Version
            // 
            this.Version.BackColor = System.Drawing.Color.Transparent;
            this.Version.BorderColor = System.Drawing.Color.BlueViolet;
            this.Version.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Version.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Version.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Version.FocusedColor = System.Drawing.Color.DarkMagenta;
            this.Version.FocusedState.BorderColor = System.Drawing.Color.DarkMagenta;
            this.Version.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Version.ForeColor = System.Drawing.Color.White;
            this.Version.ItemHeight = 30;
            this.Version.Items.AddRange(new object[] {
            "Latest",
            "1.19.40",
            "1.19.20",
            "1.19.11",
            "1.19.10",
            "1.19.2",
            "1.19.0",
            "1.18.31",
            "1.18.12",
            "1.17.11",
            "1.16.201"});
            this.Version.Location = new System.Drawing.Point(86, 117);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(192, 36);
            this.Version.StartIndex = 0;
            this.Version.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Version.TabIndex = 3;
            this.Version.SelectedIndexChanged += new System.EventHandler(this.Version_SelectedIndexChanged);
            // 
            // SupportedVersionLabel
            // 
            this.SupportedVersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.SupportedVersionLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupportedVersionLabel.ForeColor = System.Drawing.Color.White;
            this.SupportedVersionLabel.Location = new System.Drawing.Point(6, 8);
            this.SupportedVersionLabel.Name = "SupportedVersionLabel";
            this.SupportedVersionLabel.Size = new System.Drawing.Size(232, 18);
            this.SupportedVersionLabel.TabIndex = 7;
            this.SupportedVersionLabel.Text = "Supported Spoof Type: <b>CID, DID, MCID</b>";
            // 
            // VersionShadow
            // 
            this.VersionShadow.BackColor = System.Drawing.Color.Transparent;
            this.VersionShadow.Controls.Add(this.SupportedVersionLabel);
            this.VersionShadow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.VersionShadow.Location = new System.Drawing.Point(3, 505);
            this.VersionShadow.Name = "VersionShadow";
            this.VersionShadow.Radius = 6;
            this.VersionShadow.ShadowColor = System.Drawing.Color.Black;
            this.VersionShadow.Size = new System.Drawing.Size(244, 35);
            this.VersionShadow.TabIndex = 8;
            // 
            // Spoofer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.VersionShadow);
            this.Controls.Add(this.BgSpoofPanel);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Spoofer";
            this.Size = new System.Drawing.Size(781, 543);
            this.Load += new System.EventHandler(this.Spoofer_Load);
            this.BgSpoofPanel.ResumeLayout(false);
            this.VersionShadow.ResumeLayout(false);
            this.VersionShadow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel BgSpoofPanel;
        public Guna.UI2.WinForms.Guna2Button Spoof;
        private Guna.UI2.WinForms.Guna2ComboBox Version;
        private Guna.UI2.WinForms.Guna2HtmlLabel SupportedVersionLabel;
        private Guna.UI2.WinForms.Guna2ShadowPanel VersionShadow;
    }
}
