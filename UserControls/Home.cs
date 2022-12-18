using Config.Net;
using Faded_Injector.Handlers;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using static Faded_Injector.Handlers.Injection;

namespace Faded_Injector.UserControls
{
    public partial class Home : UserControl
    {
        IMySettings Config = new ConfigurationBuilder<IMySettings>().UseJsonFile($@"{Main.DataPath}\Config.json").Build();

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Clients.SelectedIndex = Config.ClientIndex;
        }

        private void Inject_Click(object sender, EventArgs e)
        {
            if (Clients.Text == "Horion")
                Process.Start("https://horion.download");
            else
                InjectClient(Clients.Text);
        }

        private void Clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.ClientIndex = Clients.SelectedIndex;
        }
    }
}
