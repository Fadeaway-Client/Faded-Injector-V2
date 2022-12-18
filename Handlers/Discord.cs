using Config.Net;
using DiscordRPC;

namespace Faded_Injector.Handlers
{
    public class Discord
    {
        public static bool IsRPCRunning { get; private set; }
        
        public static DiscordRpcClient client;
        private static IMySettings Config = new ConfigurationBuilder<IMySettings>().UseJsonFile($@"{Main.DataPath}\Config.json").Build();

        public static void StartRpc(string detail, string state)
        {
            if (string.IsNullOrEmpty(detail)) detail = "Injecting Gamer Fluid";
            if (string.IsNullOrEmpty(state)) state = "Committing Large Amounts Of Trolling";

            Config.RpcDetail = detail;
            Config.RpcState = state;

            if (!IsRPCRunning)
            {
                client = new DiscordRpcClient("980196636473049218");
                client.SetPresence(new RichPresence()
                {
                    Details = detail,
                    State = state,
                    Assets = new Assets()
                    {
                        LargeImageKey = "https://i.imgur.com/ufZN3k3.png", //Don't go above 32 characters
                        LargeImageText = "FadedInjectorV2 - Founder#8300",
                        SmallImageKey = "https://i.imgur.com/vOkR3H5.png"
                    }
                });
                client.Initialize();
                Config.RpcEnabled = true;
                IsRPCRunning = true;
            } else
            {
                UpdateRpc(detail, state);
            }
        }

        public static void UpdateRpc(string detail, string state)
        {
            if (string.IsNullOrEmpty(detail)) detail = "Injecting Gamer Fluid";
            if (string.IsNullOrEmpty(state)) state = "Committing Large Amounts Of Trolling";

            Config.RpcDetail = detail;
            Config.RpcState = state;

            if (IsRPCRunning)
            {
                client.UpdateDetails(detail);
                client.UpdateState(state);
            }
            else
            {
                StartRpc(detail, state);
            }
        }

        public static void ClearRpc()
        {
            if (IsRPCRunning)
            {
                client.ClearPresence();
            }
            Config.RpcEnabled = false;
            IsRPCRunning = false;
        }

        public static void CloseRpc()
        {
            if (IsRPCRunning)
            {
                client.ClearPresence();
            }
            IsRPCRunning = false;
        }
    }
}
