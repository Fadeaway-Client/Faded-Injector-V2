namespace Faded_Injector.UserControls
{
    partial class Home
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
            this.Inject = new Guna.UI2.WinForms.Guna2Button();
            this.Clients = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BgInjectPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.BgInjectPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Inject
            // 
            this.Inject.Animated = true;
            this.Inject.BorderRadius = 12;
            this.Inject.BorderThickness = 1;
            this.Inject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Inject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Inject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Inject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Inject.FillColor = System.Drawing.Color.BlueViolet;
            this.Inject.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inject.ForeColor = System.Drawing.Color.White;
            this.Inject.Location = new System.Drawing.Point(67, 47);
            this.Inject.Name = "Inject";
            this.Inject.Size = new System.Drawing.Size(231, 64);
            this.Inject.TabIndex = 1;
            this.Inject.Text = "Inject Client";
            this.Inject.Click += new System.EventHandler(this.Inject_Click);
            // 
            // Clients
            // 
            this.Clients.BackColor = System.Drawing.Color.Transparent;
            this.Clients.BorderColor = System.Drawing.Color.BlueViolet;
            this.Clients.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Clients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Clients.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Clients.FocusedColor = System.Drawing.Color.DarkMagenta;
            this.Clients.FocusedState.BorderColor = System.Drawing.Color.DarkMagenta;
            this.Clients.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Clients.ForeColor = System.Drawing.Color.White;
            this.Clients.ItemHeight = 30;
            this.Clients.Items.AddRange(new object[] {
            "Onix",
            "Packet",
            "Zephyr",
            "Fadeaway 1.16.201",
            "Fadeaway 1.17.11",
            "Badman",
            "Kek"});
            this.Clients.Location = new System.Drawing.Point(86, 117);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(192, 36);
            this.Clients.StartIndex = 0;
            this.Clients.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Clients.TabIndex = 3;
            this.Clients.SelectedIndexChanged += new System.EventHandler(this.Clients_SelectedIndexChanged);
            // 
            // BgInjectPanel
            // 
            this.BgInjectPanel.BackColor = System.Drawing.Color.Transparent;
            this.BgInjectPanel.Controls.Add(this.Inject);
            this.BgInjectPanel.Controls.Add(this.Clients);
            this.BgInjectPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BgInjectPanel.Location = new System.Drawing.Point(208, 176);
            this.BgInjectPanel.Name = "BgInjectPanel";
            this.BgInjectPanel.Radius = 6;
            this.BgInjectPanel.ShadowColor = System.Drawing.Color.Black;
            this.BgInjectPanel.Size = new System.Drawing.Size(364, 190);
            this.BgInjectPanel.TabIndex = 4;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.BgInjectPanel);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(781, 543);
            this.Load += new System.EventHandler(this.Home_Load);
            this.BgInjectPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox Clients;
        private Guna.UI2.WinForms.Guna2ShadowPanel BgInjectPanel;
        public Guna.UI2.WinForms.Guna2Button Inject;
    }
}
