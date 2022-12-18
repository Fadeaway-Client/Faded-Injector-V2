namespace Faded_Injector.UserControls
{
    partial class Developer
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
            this.BgInjectPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.SelectDll = new Guna.UI2.WinForms.Guna2Button();
            this.Inject = new Guna.UI2.WinForms.Guna2Button();
            this.DllPathLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BgPatchingPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.Patch = new Guna.UI2.WinForms.Guna2Button();
            this.NewValueLabel = new System.Windows.Forms.Label();
            this.ValueTypeLabel = new System.Windows.Forms.Label();
            this.PointerLabel = new System.Windows.Forms.Label();
            this.NewValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.ValueType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Pointer = new Guna.UI2.WinForms.Guna2TextBox();
            this.BgInjectPanel.SuspendLayout();
            this.BgPatchingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BgInjectPanel
            // 
            this.BgInjectPanel.BackColor = System.Drawing.Color.Transparent;
            this.BgInjectPanel.Controls.Add(this.SelectDll);
            this.BgInjectPanel.Controls.Add(this.Inject);
            this.BgInjectPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BgInjectPanel.Location = new System.Drawing.Point(19, 176);
            this.BgInjectPanel.Name = "BgInjectPanel";
            this.BgInjectPanel.Radius = 6;
            this.BgInjectPanel.ShadowColor = System.Drawing.Color.Black;
            this.BgInjectPanel.Size = new System.Drawing.Size(364, 190);
            this.BgInjectPanel.TabIndex = 5;
            // 
            // SelectDll
            // 
            this.SelectDll.Animated = true;
            this.SelectDll.BorderRadius = 12;
            this.SelectDll.BorderThickness = 1;
            this.SelectDll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SelectDll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SelectDll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SelectDll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SelectDll.FillColor = System.Drawing.Color.BlueViolet;
            this.SelectDll.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectDll.ForeColor = System.Drawing.Color.White;
            this.SelectDll.Location = new System.Drawing.Point(88, 105);
            this.SelectDll.Name = "SelectDll";
            this.SelectDll.Size = new System.Drawing.Size(188, 50);
            this.SelectDll.TabIndex = 2;
            this.SelectDll.Text = "Select DLL";
            this.SelectDll.Click += new System.EventHandler(this.SelectDll_Click);
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
            this.Inject.Location = new System.Drawing.Point(67, 35);
            this.Inject.Name = "Inject";
            this.Inject.Size = new System.Drawing.Size(231, 64);
            this.Inject.TabIndex = 1;
            this.Inject.Text = "Inject DLL";
            this.Inject.Click += new System.EventHandler(this.Inject_Click);
            // 
            // DllPathLabel
            // 
            this.DllPathLabel.BackColor = System.Drawing.Color.Transparent;
            this.DllPathLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DllPathLabel.ForeColor = System.Drawing.Color.White;
            this.DllPathLabel.Location = new System.Drawing.Point(3, 522);
            this.DllPathLabel.Name = "DllPathLabel";
            this.DllPathLabel.Size = new System.Drawing.Size(147, 18);
            this.DllPathLabel.TabIndex = 6;
            this.DllPathLabel.Text = "DLL Path: <b>Select A DLL</b>";
            // 
            // BgPatchingPanel
            // 
            this.BgPatchingPanel.BackColor = System.Drawing.Color.Transparent;
            this.BgPatchingPanel.Controls.Add(this.Patch);
            this.BgPatchingPanel.Controls.Add(this.NewValueLabel);
            this.BgPatchingPanel.Controls.Add(this.ValueTypeLabel);
            this.BgPatchingPanel.Controls.Add(this.PointerLabel);
            this.BgPatchingPanel.Controls.Add(this.NewValue);
            this.BgPatchingPanel.Controls.Add(this.ValueType);
            this.BgPatchingPanel.Controls.Add(this.Pointer);
            this.BgPatchingPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BgPatchingPanel.Location = new System.Drawing.Point(397, 139);
            this.BgPatchingPanel.Name = "BgPatchingPanel";
            this.BgPatchingPanel.Radius = 6;
            this.BgPatchingPanel.ShadowColor = System.Drawing.Color.Black;
            this.BgPatchingPanel.Size = new System.Drawing.Size(364, 265);
            this.BgPatchingPanel.TabIndex = 7;
            // 
            // Patch
            // 
            this.Patch.Animated = true;
            this.Patch.BorderRadius = 12;
            this.Patch.BorderThickness = 1;
            this.Patch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Patch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Patch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Patch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Patch.FillColor = System.Drawing.Color.BlueViolet;
            this.Patch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patch.ForeColor = System.Drawing.Color.White;
            this.Patch.Location = new System.Drawing.Point(85, 205);
            this.Patch.Name = "Patch";
            this.Patch.Size = new System.Drawing.Size(195, 36);
            this.Patch.TabIndex = 8;
            this.Patch.Text = "Patch";
            this.Patch.Click += new System.EventHandler(this.Patch_Click);
            // 
            // NewValueLabel
            // 
            this.NewValueLabel.AutoSize = true;
            this.NewValueLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewValueLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.NewValueLabel.Location = new System.Drawing.Point(81, 146);
            this.NewValueLabel.Name = "NewValueLabel";
            this.NewValueLabel.Size = new System.Drawing.Size(60, 14);
            this.NewValueLabel.TabIndex = 7;
            this.NewValueLabel.Text = "New Value";
            // 
            // ValueTypeLabel
            // 
            this.ValueTypeLabel.AutoSize = true;
            this.ValueTypeLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueTypeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.ValueTypeLabel.Location = new System.Drawing.Point(81, 87);
            this.ValueTypeLabel.Name = "ValueTypeLabel";
            this.ValueTypeLabel.Size = new System.Drawing.Size(60, 14);
            this.ValueTypeLabel.TabIndex = 6;
            this.ValueTypeLabel.Text = "Value Type";
            // 
            // PointerLabel
            // 
            this.PointerLabel.AutoSize = true;
            this.PointerLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointerLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.PointerLabel.Location = new System.Drawing.Point(81, 28);
            this.PointerLabel.Name = "PointerLabel";
            this.PointerLabel.Size = new System.Drawing.Size(40, 14);
            this.PointerLabel.TabIndex = 5;
            this.PointerLabel.Text = "Pointer";
            // 
            // NewValue
            // 
            this.NewValue.Animated = true;
            this.NewValue.BorderColor = System.Drawing.Color.BlueViolet;
            this.NewValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewValue.DefaultText = "";
            this.NewValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NewValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NewValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewValue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.NewValue.FocusedState.BorderColor = System.Drawing.Color.DarkMagenta;
            this.NewValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewValue.ForeColor = System.Drawing.Color.White;
            this.NewValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewValue.Location = new System.Drawing.Point(84, 163);
            this.NewValue.Name = "NewValue";
            this.NewValue.PasswordChar = '\0';
            this.NewValue.PlaceholderText = "New Value";
            this.NewValue.SelectedText = "";
            this.NewValue.Size = new System.Drawing.Size(196, 36);
            this.NewValue.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.NewValue.TabIndex = 4;
            // 
            // ValueType
            // 
            this.ValueType.BackColor = System.Drawing.Color.Transparent;
            this.ValueType.BorderColor = System.Drawing.Color.BlueViolet;
            this.ValueType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ValueType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ValueType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ValueType.FocusedColor = System.Drawing.Color.DarkMagenta;
            this.ValueType.FocusedState.BorderColor = System.Drawing.Color.DarkMagenta;
            this.ValueType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ValueType.ForeColor = System.Drawing.Color.White;
            this.ValueType.ItemHeight = 30;
            this.ValueType.Items.AddRange(new object[] {
            "string",
            "integer",
            "float",
            "byte",
            "bytes",
            "long"});
            this.ValueType.Location = new System.Drawing.Point(84, 104);
            this.ValueType.Name = "ValueType";
            this.ValueType.Size = new System.Drawing.Size(196, 36);
            this.ValueType.StartIndex = 0;
            this.ValueType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ValueType.TabIndex = 3;
            // 
            // Pointer
            // 
            this.Pointer.Animated = true;
            this.Pointer.BorderColor = System.Drawing.Color.BlueViolet;
            this.Pointer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pointer.DefaultText = "";
            this.Pointer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Pointer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Pointer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pointer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pointer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Pointer.FocusedState.BorderColor = System.Drawing.Color.DarkMagenta;
            this.Pointer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Pointer.ForeColor = System.Drawing.Color.White;
            this.Pointer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pointer.Location = new System.Drawing.Point(84, 45);
            this.Pointer.Name = "Pointer";
            this.Pointer.PasswordChar = '\0';
            this.Pointer.PlaceholderText = "Pointer";
            this.Pointer.SelectedText = "";
            this.Pointer.Size = new System.Drawing.Size(196, 36);
            this.Pointer.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Pointer.TabIndex = 2;
            // 
            // Developer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.BgPatchingPanel);
            this.Controls.Add(this.DllPathLabel);
            this.Controls.Add(this.BgInjectPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Developer";
            this.Size = new System.Drawing.Size(781, 543);
            this.Load += new System.EventHandler(this.Developer_Load);
            this.BgInjectPanel.ResumeLayout(false);
            this.BgPatchingPanel.ResumeLayout(false);
            this.BgPatchingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel BgInjectPanel;
        public Guna.UI2.WinForms.Guna2Button Inject;
        public Guna.UI2.WinForms.Guna2Button SelectDll;
        private Guna.UI2.WinForms.Guna2HtmlLabel DllPathLabel;
        private Guna.UI2.WinForms.Guna2ShadowPanel BgPatchingPanel;
        private Guna.UI2.WinForms.Guna2TextBox Pointer;
        private Guna.UI2.WinForms.Guna2TextBox NewValue;
        private Guna.UI2.WinForms.Guna2ComboBox ValueType;
        public Guna.UI2.WinForms.Guna2Button Patch;
        private System.Windows.Forms.Label NewValueLabel;
        private System.Windows.Forms.Label ValueTypeLabel;
        private System.Windows.Forms.Label PointerLabel;
    }
}
