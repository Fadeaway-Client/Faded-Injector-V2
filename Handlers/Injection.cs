using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Security.Principal;
using System.IO;
using Config.Net;

namespace Faded_Injector.Handlers
{
    public class Injection
    {
        static IMySettings Config = new ConfigurationBuilder<IMySettings>().UseJsonFile($@"{Main.DataPath}\Config.json").Build();

        //Credits Echo
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress,
            uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        static extern IntPtr CreateRemoteThread(IntPtr hProcess,
            IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        // privileges
        const int PROCESS_CREATE_THREAD = 0x0002;
        const int PROCESS_QUERY_INFORMATION = 0x0400;
        const int PROCESS_VM_OPERATION = 0x0008;
        const int PROCESS_VM_WRITE = 0x0020;
        const int PROCESS_VM_READ = 0x0010;

        // used for memory allocation
        const uint MEM_COMMIT = 0x00001000;
        const uint MEM_RESERVE = 0x00002000;
        const uint PAGE_READWRITE = 4;

        public static void InjectDLL(string path)
        {
            Process[] targetProcessIndex = Process.GetProcessesByName("Minecraft.Windows");
            if (targetProcessIndex.Length > 0)
            {
                if (Config.AutoFocus)
                    Process.Start("minecraft://");

                ApplyAccess(path);

                Process targetProcess = Process.GetProcessesByName("Minecraft.Windows")[0];
                IntPtr procHandle = OpenProcess(PROCESS_CREATE_THREAD | PROCESS_QUERY_INFORMATION | PROCESS_VM_OPERATION | PROCESS_VM_WRITE | PROCESS_VM_READ, false, targetProcess.Id);

                IntPtr loadLibraryAddr = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");

                IntPtr allocMemAddress = VirtualAllocEx(procHandle, IntPtr.Zero, (uint)((path.Length + 1) * Marshal.SizeOf(typeof(char))), MEM_COMMIT | MEM_RESERVE, PAGE_READWRITE);

                UIntPtr bytesWritten;
                WriteProcessMemory(procHandle, allocMemAddress, Encoding.Default.GetBytes(path), (uint)((path.Length + 1) * Marshal.SizeOf(typeof(char))), out bytesWritten);
                CreateRemoteThread(procHandle, IntPtr.Zero, 0, loadLibraryAddr, allocMemAddress, 0, IntPtr.Zero);
            }
            else
            {
                Process.Start("minecraft://");
                Thread.Sleep(7000);
                InjectDLL(path);
            }
        }

        private static void ApplyAccess(string path)
        {
            FileInfo InfoFile = new FileInfo(path);
            FileSecurity fSecurity = InfoFile.GetAccessControl();
            fSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier("S-1-15-2-1"), FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            InfoFile.SetAccessControl(fSecurity);
        }

        public static async void InjectClient(string client)
        {
            WebClient webClient = new WebClient();
            string downloadUrl;
            switch (client)
            {
                default:
                    downloadUrl = $@"https://github.com/FadedKow/Assets/raw/main/MCBE%20Clients/{client}.dll".Replace(' ', '%');
                    break;
                case "Onix":
                    downloadUrl = "https://github.com/bernarddesfosse/onixclientautoupdate/raw/main/OnixClient.dll";
                    break;
                case "Packet":
                    downloadUrl = "https://github.com/PacketDeveloper/PacketClientDLLS/raw/main/PacketClient.dll";
                    break;
                case "Badman":
                    downloadUrl = "https://github.com/BadMan-Client/BadMan-Releases/releases/latest/download/BadManPublic.dll";
                    break;
                case "Fadeaway 1.16.201":
                    downloadUrl = "https://github.com/FadedKow/Assets/raw/main/MCBE%20Clients/Fadeaway%201.16.201.dll";
                    break;
                case "Fadeaway 1.17.11":
                    downloadUrl = "https://github.com/FadedKow/Assets/raw/main/MCBE%20Clients/Fadeaway%201.17.11.1.dll";
                    break;
            }

            if (Config.AutoUpdate)
                await webClient.DownloadFileTaskAsync(downloadUrl, Main.DataPath + $@"\{client.Replace('%', '_')}.dll");
            else
                if (!File.Exists($@"{Main.DataPath}\{client.Replace(' ', '_')}.dll"))
                    await webClient.DownloadFileTaskAsync(downloadUrl, Main.DataPath + $@"\{client.Replace('%', '_')}.dll");

            Thread.Sleep(50);
            InjectDLL($@"{Main.DataPath}\{client.Replace(' ', '_')}.dll");
        }
    }
}
