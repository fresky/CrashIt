using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace CrashIt
{
    class CrashInjecter
    {
        [Flags]
        public enum ProcessAccessFlags : uint
        {
            All = 0x001F0FFF,
            Terminate = 0x00000001,
            CreateThread = 0x00000002,
            VirtualMemoryOperation = 0x00000008,
            VirtualMemoryRead = 0x00000010,
            VirtualMemoryWrite = 0x00000020,
            DuplicateHandle = 0x00000040,
            CreateProcess = 0x000000080,
            SetQuota = 0x00000100,
            SetInformation = 0x00000200,
            QueryInformation = 0x00000400,
            QueryLimitedInformation = 0x00001000,
            Synchronize = 0x00100000
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(
            ProcessAccessFlags processAccess,
            bool bInheritHandle,
            int processId
        );

        [DllImport("kernel32.dll")]
        static extern IntPtr CreateRemoteThread(IntPtr hProcess,
            IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress,
            IntPtr lpParameter, uint dwCreationFlags, out IntPtr lpThreadId);

        public static bool Crash(int processId)
        {
            var hProcess = OpenProcess(ProcessAccessFlags.All, false, processId);
            if (hProcess == IntPtr.Zero)
            {
                return false;
            }
            CreateRemoteThread(hProcess, IntPtr.Zero, 0, IntPtr.Zero, IntPtr.Zero, 0, out _);
            return true;
        }

        public static bool Crash(string[] args)
        {
            if (args[1].ToLower().Contains("id:"))
            {
                string id = args[1].Replace("id:", string.Empty).Trim();
                int pid;
                if (int.TryParse(id, out pid))
                {
                    return Crash(pid);
                }
                return false;
            }
            string processName = args[1];

            var processes = Process.GetProcessesByName(processName).Where(p => !p.HasExited).ToArray();
            if (processes.Length == 1)
            {
                return Crash(processes[0].Id);
            }
            if (args.Length == 3)
            {
                string title = args[2].ToLower();
                foreach (var process in processes)
                {
                    if (process.MainWindowTitle.ToLower().Contains(title))
                    {
                        return Crash(process.Id);
                    }
                }
            }
            return false;
        }
    }
}
