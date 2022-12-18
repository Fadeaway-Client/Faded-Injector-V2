using Config.Net;
using Faded_Injector.Handlers;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static Faded_Injector.Handlers.Discord;
using static Faded_Injector.Utils.Background;

namespace Faded_Injector.UserControls
{
    public partial class Settings : UserControl
    {
        IMySettings Config = new ConfigurationBuilder<IMySettings>().UseJsonFile($@"{Main.DataPath}\Config.json").Build();
        Main mf = (Main)Application.OpenForms["Main"];
        
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Themes.SelectedIndex = Config.ThemeIndex;

            if (Config.RpcEnabled)
                Rpc.Checked = true;
            Detail.Text = Config.RpcDetail;
            State.Text = Config.RpcState;

            if (Config.AutoFocus)
                AutoFocus.Checked = true;
            else
                AutoFocus.Checked = false;

            if (Config.AutoUpdate)
                AutoUpdate.Checked = true;
            else
                AutoUpdate.Checked = false;
        }

        private void ChooseBg_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Open = new OpenFileDialog();
                Open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif)|*.jpg; *.png; *.jpeg; *.gif;)";
                if (Open.ShowDialog() == DialogResult.OK)
                {
                    SetTheme(0);
                    Themes.SelectedIndex = 0;
                    string ImageFile = Open.FileName;
                    Image Img = Image.FromFile(ImageFile);
                    mf.BackgroundImage = Img;
                    mf.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Wallpaper Error");
            }
        }

        private void Themes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTheme(Themes.SelectedIndex);
            Config.ThemeIndex = Themes.SelectedIndex;
        }

        private void ResetBg_Click(object sender, EventArgs e)
        {
            Themes.SelectedIndex = 0;
            mf.BackgroundImage = null;
            mf.BackColor = Color.FromArgb(255, 30, 30, 30);
        }

        private void Rpc_CheckedChanged(object sender, EventArgs e)
        {
            if (Rpc.Checked)
            {
                StartRpc(Detail.Text, State.Text);
            } else
            {
                ClearRpc();
            }
        }

        private void UpdateRpc_Click(object sender, EventArgs e)
        {
            UpdateRpc(Detail.Text, State.Text);
            Rpc.Checked = true;
            Config.RpcDetail = Detail.Text;
            Config.RpcState = State.Text;
        }

        private void DataDir_Click(object sender, EventArgs e)
        {
            Process.Start(Main.DataPath);
        }

        private void AppDir_Click(object sender, EventArgs e)
        {
            Process.Start(Main.AppPath);
        }

        private void AutoFocus_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoFocus.Checked)
                Config.AutoFocus = true;
            else
                Config.AutoFocus = false;
        }

        private void AutoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoUpdate.Checked)
                Config.AutoUpdate = true;
            else
                Config.AutoUpdate = false;
        }
    }
}
