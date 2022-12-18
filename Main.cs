using Config.Net;
using Faded_Injector.Handlers;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Faded_Injector
{
    public partial class Main : Form
    {
        IMySettings Config = new ConfigurationBuilder<IMySettings>().UseJsonFile($@"{DataPath}\Config.json").Build();
        public static readonly string DataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\FadedInjector";
        public static readonly string AppPath = Directory.GetCurrentDirectory();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(DataPath))
                Directory.CreateDirectory(DataPath);

            Utils.Background.SetTheme(Config.ThemeIndex);
            Utils.App.SetWatermark(Config.WatermarkPath);

            if (Config.RpcEnabled)
                Discord.StartRpc(Config.RpcDetail, Config.RpcState);

            ControlContainer.Controls.Clear();
            ControlContainer.Controls.Add(new UserControls.Home());
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Discord.CloseRpc();
            Dispose();
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            ControlContainer.Controls.Clear();
            ControlContainer.Controls.Add(new UserControls.Settings());
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            ControlContainer.Controls.Clear();
            ControlContainer.Controls.Add(new UserControls.Home());
        }

        private void DeveloperBtn_Click(object sender, EventArgs e)
        {
            ControlContainer.Controls.Clear();
            ControlContainer.Controls.Add(new UserControls.Developer());
        }

        private void SpoofBtn_Click(object sender, EventArgs e)
        {
            ControlContainer.Controls.Clear();
            ControlContainer.Controls.Add(new UserControls.Spoofer());
        }

        private void WatermarkLogo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Open = new OpenFileDialog();
                Open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif)|*.jpg; *.png; *.jpeg; *.gif;)";
                if (Open.ShowDialog() == DialogResult.OK)
                {
                    string ImageFile = Open.FileName;
                    Image Img = Image.FromFile(ImageFile);
                    WatermarkLogo.Image = Img;
                    WatermarkLogo.Refresh();
                    Config.WatermarkPath = ImageFile;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Wallpaper Error");
            }
        }
    }
}
