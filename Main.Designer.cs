namespace Faded_Injector
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Shadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.Category = new Guna.UI2.WinForms.Guna2Panel();
            this.SpoofBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Setting = new Guna.UI2.WinForms.Guna2Button();
            this.Minimize = new Guna.UI2.WinForms.Guna2Button();
            this.Exit = new Guna.UI2.WinForms.Guna2Button();
            this.DeveloperBtn = new Guna.UI2.WinForms.Guna2Button();
            this.HomeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.WatermarkPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.WatermarkText = new System.Windows.Forms.Label();
            this.WatermarkLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.DragCat = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragMain = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragWatermark = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ControlContainer = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.Category.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.WatermarkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WatermarkLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 16;
            this.Elipse.TargetControl = this;
            // 
            // Shadow
            // 
            this.Shadow.BorderRadius = 20;
            this.Shadow.TargetForm = this;
            // 
            // Category
            // 
            this.Category.BackColor = System.Drawing.Color.Transparent;
            this.Category.Controls.Add(this.SpoofBtn);
            this.Category.Controls.Add(this.guna2Panel1);
            this.Category.Controls.Add(this.DeveloperBtn);
            this.Category.Controls.Add(this.HomeBtn);
            this.Category.Controls.Add(this.WatermarkPanel);
            this.Category.CustomBorderColor = System.Drawing.Color.Black;
            this.Category.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.Category.Dock = System.Windows.Forms.DockStyle.Left;
            this.Category.Location = new System.Drawing.Point(0, 0);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(179, 543);
            this.Category.TabIndex = 0;
            this.Category.UseTransparentBackground = true;
            // 
            // SpoofBtn
            // 
            this.SpoofBtn.Animated = true;
            this.SpoofBtn.BorderRadius = 6;
            this.SpoofBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.SpoofBtn.CheckedState.CustomBorderColor = System.Drawing.Color.BlueViolet;
            this.SpoofBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SpoofBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.SpoofBtn.CustomBorderColor = System.Drawing.Color.Transparent;
            this.SpoofBtn.CustomBorderThickness = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.SpoofBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SpoofBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SpoofBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SpoofBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SpoofBtn.FillColor = System.Drawing.Color.Transparent;
            this.SpoofBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpoofBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.SpoofBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SpoofBtn.Image = global::Faded_Injector.Properties.Resources.spyware;
            this.SpoofBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SpoofBtn.Location = new System.Drawing.Point(13, 222);
            this.SpoofBtn.Name = "SpoofBtn";
            this.SpoofBtn.Size = new System.Drawing.Size(153, 45);
            this.SpoofBtn.TabIndex = 7;
            this.SpoofBtn.Text = "Spoofer";
            this.SpoofBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SpoofBtn.UseTransparentBackground = true;
            this.SpoofBtn.Click += new System.EventHandler(this.SpoofBtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.Setting);
            this.guna2Panel1.Controls.Add(this.Minimize);
            this.guna2Panel1.Controls.Add(this.Exit);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 57);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(179, 57);
            this.guna2Panel1.TabIndex = 6;
            this.guna2Panel1.UseTransparentBackground = true;
            // 
            // Setting
            // 
            this.Setting.Animated = true;
            this.Setting.BorderRadius = 3;
            this.Setting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Setting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Setting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Setting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Setting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Setting.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Setting.ForeColor = System.Drawing.Color.White;
            this.Setting.Image = global::Faded_Injector.Properties.Resources.settings;
            this.Setting.ImageSize = new System.Drawing.Size(18, 18);
            this.Setting.Location = new System.Drawing.Point(111, 12);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(32, 32);
            this.Setting.TabIndex = 2;
            this.Setting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // Minimize
            // 
            this.Minimize.Animated = true;
            this.Minimize.BorderRadius = 3;
            this.Minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Minimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Minimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Image = global::Faded_Injector.Properties.Resources.invisible;
            this.Minimize.ImageSize = new System.Drawing.Size(18, 18);
            this.Minimize.Location = new System.Drawing.Point(73, 12);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(32, 32);
            this.Minimize.TabIndex = 1;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.Animated = true;
            this.Exit.BorderRadius = 3;
            this.Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Image = global::Faded_Injector.Properties.Resources.exit;
            this.Exit.ImageSize = new System.Drawing.Size(18, 18);
            this.Exit.Location = new System.Drawing.Point(35, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(32, 32);
            this.Exit.TabIndex = 0;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DeveloperBtn
            // 
            this.DeveloperBtn.Animated = true;
            this.DeveloperBtn.BorderRadius = 6;
            this.DeveloperBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.DeveloperBtn.CheckedState.CustomBorderColor = System.Drawing.Color.BlueViolet;
            this.DeveloperBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.DeveloperBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.DeveloperBtn.CustomBorderColor = System.Drawing.Color.Transparent;
            this.DeveloperBtn.CustomBorderThickness = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.DeveloperBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeveloperBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeveloperBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeveloperBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeveloperBtn.FillColor = System.Drawing.Color.Transparent;
            this.DeveloperBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeveloperBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.DeveloperBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DeveloperBtn.Image = global::Faded_Injector.Properties.Resources.dll;
            this.DeveloperBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DeveloperBtn.Location = new System.Drawing.Point(13, 171);
            this.DeveloperBtn.Name = "DeveloperBtn";
            this.DeveloperBtn.Size = new System.Drawing.Size(153, 45);
            this.DeveloperBtn.TabIndex = 3;
            this.DeveloperBtn.Text = "Developer";
            this.DeveloperBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DeveloperBtn.UseTransparentBackground = true;
            this.DeveloperBtn.Click += new System.EventHandler(this.DeveloperBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Animated = true;
            this.HomeBtn.BorderRadius = 6;
            this.HomeBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.HomeBtn.Checked = true;
            this.HomeBtn.CheckedState.CustomBorderColor = System.Drawing.Color.BlueViolet;
            this.HomeBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.HomeBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.CustomBorderColor = System.Drawing.Color.Transparent;
            this.HomeBtn.CustomBorderThickness = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.HomeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HomeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HomeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HomeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HomeBtn.FillColor = System.Drawing.Color.Transparent;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.HomeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.HomeBtn.Image = global::Faded_Injector.Properties.Resources.home;
            this.HomeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomeBtn.Location = new System.Drawing.Point(13, 120);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(153, 45);
            this.HomeBtn.TabIndex = 2;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomeBtn.UseTransparentBackground = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // WatermarkPanel
            // 
            this.WatermarkPanel.BorderColor = System.Drawing.Color.Transparent;
            this.WatermarkPanel.Controls.Add(this.WatermarkText);
            this.WatermarkPanel.Controls.Add(this.WatermarkLogo);
            this.WatermarkPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WatermarkPanel.Location = new System.Drawing.Point(0, 0);
            this.WatermarkPanel.Name = "WatermarkPanel";
            this.WatermarkPanel.Size = new System.Drawing.Size(179, 57);
            this.WatermarkPanel.TabIndex = 0;
            this.WatermarkPanel.UseTransparentBackground = true;
            // 
            // WatermarkText
            // 
            this.WatermarkText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WatermarkText.AutoSize = true;
            this.WatermarkText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WatermarkText.Location = new System.Drawing.Point(47, 20);
            this.WatermarkText.Name = "WatermarkText";
            this.WatermarkText.Size = new System.Drawing.Size(107, 16);
            this.WatermarkText.TabIndex = 1;
            this.WatermarkText.Text = "Faded Injector";
            // 
            // WatermarkLogo
            // 
            this.WatermarkLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WatermarkLogo.FillColor = System.Drawing.Color.Transparent;
            this.WatermarkLogo.Image = global::Faded_Injector.Properties.Resources.fadeaway7Glow;
            this.WatermarkLogo.ImageRotate = 0F;
            this.WatermarkLogo.Location = new System.Drawing.Point(13, 10);
            this.WatermarkLogo.Name = "WatermarkLogo";
            this.WatermarkLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.WatermarkLogo.Size = new System.Drawing.Size(37, 37);
            this.WatermarkLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WatermarkLogo.TabIndex = 0;
            this.WatermarkLogo.TabStop = false;
            this.WatermarkLogo.UseTransparentBackground = true;
            this.WatermarkLogo.Click += new System.EventHandler(this.WatermarkLogo_Click);
            // 
            // DragCat
            // 
            this.DragCat.DockIndicatorTransparencyValue = 0.6D;
            this.DragCat.TargetControl = this.Category;
            this.DragCat.UseTransparentDrag = true;
            // 
            // DragMain
            // 
            this.DragMain.DockIndicatorTransparencyValue = 0.6D;
            this.DragMain.TargetControl = this;
            this.DragMain.UseTransparentDrag = true;
            // 
            // DragWatermark
            // 
            this.DragWatermark.DockIndicatorTransparencyValue = 0.6D;
            this.DragWatermark.TargetControl = this.WatermarkPanel;
            this.DragWatermark.UseTransparentDrag = true;
            // 
            // ControlContainer
            // 
            this.ControlContainer.BackColor = System.Drawing.Color.Transparent;
            this.ControlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlContainer.FillColor = System.Drawing.Color.Transparent;
            this.ControlContainer.Location = new System.Drawing.Point(179, 0);
            this.ControlContainer.Name = "ControlContainer";
            this.ControlContainer.Size = new System.Drawing.Size(781, 543);
            this.ControlContainer.TabIndex = 1;
            this.ControlContainer.UseTransparentBackground = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(960, 543);
            this.Controls.Add(this.ControlContainer);
            this.Controls.Add(this.Category);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faded Injector";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Category.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.WatermarkPanel.ResumeLayout(false);
            this.WatermarkPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WatermarkLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2ShadowForm Shadow;
        private Guna.UI2.WinForms.Guna2Panel Category;
        private Guna.UI2.WinForms.Guna2Panel WatermarkPanel;
        private System.Windows.Forms.Label WatermarkText;
        private Guna.UI2.WinForms.Guna2Button HomeBtn;
        private Guna.UI2.WinForms.Guna2Button DeveloperBtn;
        private Guna.UI2.WinForms.Guna2DragControl DragCat;
        private Guna.UI2.WinForms.Guna2DragControl DragMain;
        private Guna.UI2.WinForms.Guna2DragControl DragWatermark;
        private Guna.UI2.WinForms.Guna2ContainerControl ControlContainer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button Exit;
        private Guna.UI2.WinForms.Guna2Button Minimize;
        private Guna.UI2.WinForms.Guna2Button Setting;
        private Guna.UI2.WinForms.Guna2Button SpoofBtn;
        public Guna.UI2.WinForms.Guna2CirclePictureBox WatermarkLogo;
    }
}

