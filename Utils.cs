using System;
using System.Drawing;
using System.Windows.Forms;
using Config.Net;
using Faded_Injector.Handlers;

namespace Faded_Injector
{
    public class Utils
    {
        static IMySettings Config = new ConfigurationBuilder<IMySettings>().UseJsonFile($@"{Main.DataPath}\Config.json").Build();
        static Main mf = (Main)Application.OpenForms["Main"];

        public class Background
        {
            public static void SetTheme(int ThemeIndex)
            {
                switch (ThemeIndex)
                {
                    case 0:
                        SetColor(Color.FromArgb(255, 30, 30, 30));
                        SetImage(null);
                        break;
                    case 1:
                        SetImage(Properties.Resources.fadedproxybg);
                        break;
                    case 2:
                        SetColor(Color.FromArgb(255, 30, 30, 30));
                        SetImage(Properties.Resources.bigrat);
                        break;
                    case 3:
                        SetColor(Color.FromArgb(255, 0, 0, 0));
                        SetImage(null);
                        break;
                }
            }

            public static void SetColor(Color color)
            {
                mf.BackColor = color;
            }

            public static void SetImage(Image image)
            {
                mf.BackgroundImage = image;
            }
        }

        public class App
        {
            public static void SetWatermark(string iconPath)
            {
                if (string.IsNullOrEmpty(iconPath)) return;
                try
                {
                    Image Img = Image.FromFile(iconPath);
                    mf.WatermarkLogo.Image = Img;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Watermark failed to load, it has automatically been reset. Error is printed below:\n"+ex.Message, "Watermark Error");
                    mf.WatermarkLogo.Image = Properties.Resources.fadeaway7Glow;
                    Config.WatermarkPath = "";
                }
            }
        }
    }
}
