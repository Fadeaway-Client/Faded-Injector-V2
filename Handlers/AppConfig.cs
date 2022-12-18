using Config.Net;

namespace Faded_Injector.Handlers
{
    public interface IMySettings
    {
        //Main
        [Option(DefaultValue = "")]
        string WatermarkPath { get; set; }

        //Theme
        [Option(DefaultValue = 0)]
        int ThemeIndex { get; set; }

        //Discord
        bool RpcEnabled { get; set; }
        [Option(DefaultValue = "Injecting Gamer Fluid")]
        string RpcDetail { get; set; }
        [Option(DefaultValue = "Committing Large Amounts Of Trolling")]
        string RpcState { get; set; }

        //Minecraft
        [Option(DefaultValue = true)]
        bool AutoFocus { get; set; }
        [Option(DefaultValue = true)]
        bool AutoUpdate { get; set; }

        //Home
        [Option(DefaultValue = 0)]
        int ClientIndex { get; set; }

        //Developer
        string DllPath { get; set; }

        //Spoofer
        [Option(DefaultValue = 0)]
        int VersionIndex { get; set; }
    }
}
