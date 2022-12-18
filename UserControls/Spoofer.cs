using Config.Net;
using Faded_Injector.Handlers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Faded_Injector.UserControls
{
    public partial class Spoofer : UserControl
    {
        IMySettings Config = new ConfigurationBuilder<IMySettings>().UseJsonFile($@"{Main.DataPath}\Config.json").Build();

        public Spoofer()
        {
            InitializeComponent();
        }

        void UpdateSupportedVersionLabel(string gameVersion)
        {
            switch (gameVersion)
            {
                default:
                    SupportedVersionLabel.Text = "Supported Spoof Type: <b>CID, DID, MCID</b>";
                    break;
                case "1.17.11":
                    SupportedVersionLabel.Text = "Supported Spoof Type: <b>CID, DID</b>";
                    break;
                case "1.16.201":
                    SupportedVersionLabel.Text = "Supported Spoof Type: <b>CID, DID</b>";
                    break;
            }
            VersionShadow.Size = new Size(SupportedVersionLabel.Text.Length * 6 - 14, 35);
        }

        private void Spoofer_Load(object sender, EventArgs e)
        {
            Version.SelectedIndex = Config.VersionIndex;
            UpdateSupportedVersionLabel(Version.Text);
        }

        private void Spoof_Click(object sender, EventArgs e)
        {
            Handlers.Spoof.DoTheSpoof(Version.Text);
        }

        private void Version_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSupportedVersionLabel(Version.Text);
            Config.VersionIndex = Version.SelectedIndex;
        }
    }
}
