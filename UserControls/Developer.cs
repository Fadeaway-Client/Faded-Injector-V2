using System;
using System.Windows.Forms;
using Config.Net;
using Faded_Injector.Handlers;

namespace Faded_Injector.UserControls
{
    public partial class Developer : UserControl
    {
        IMySettings Config = new ConfigurationBuilder<IMySettings>().UseJsonFile($@"{Main.DataPath}\Config.json").Build();
        public static string FilePath;

        public Developer()
        {
            InitializeComponent();
        }

        private void Developer_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Config.DllPath))
            {
                DllPathLabel.Text = $"DLL Path: <b>{Config.DllPath}</b>";
                FilePath = Config.DllPath;
            }
        }

        private void SelectDll_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileIn = new OpenFileDialog();
            FileIn.Filter = "dll |*.dll";
            if (FileIn.ShowDialog() == DialogResult.OK)
            {
                if (FileIn.SafeFileName.ToLower().EndsWith(".dll"))
                {
                    FilePath = FileIn.FileName;
                    DllPathLabel.Text = $"DLL Path: <b>{FilePath}</b>";
                    Config.DllPath = FilePath;
                }
                else
                {
                    MessageBox.Show("You did not specify a DLL!");
                }
            }
        }

        private void Inject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilePath))
            {
                MessageBox.Show("Please Select a DLL File", "Path Error");
                return;
            }

            Injection.InjectDLL(FilePath);
        }

        private void Patch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Pointer.Text) && !string.IsNullOrEmpty(NewValue.Text))
                Spoof.PatchMemory(Pointer.Text, ValueType.Text, NewValue.Text);
        }
    }
}
