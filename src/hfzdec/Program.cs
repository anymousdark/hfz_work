using System.Diagnostics;
using System.Runtime.InteropServices;

namespace HfzDec;

class Program
{
    [DllImport("kernel32.dll", SetLastError = true)]
    static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern bool VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MEMORY_BASIC_INFORMATION lpBuffer, int dwLength);

    [StructLayout(LayoutKind.Sequential)]
    struct MEMORY_BASIC_INFORMATION
    {
        public IntPtr BaseAddress;
        public IntPtr AllocationBase;
        public uint AllocationProtect;
        public IntPtr RegionSize;
        public uint State;
        public uint Protect;
        public uint Type;
    }

    static async Task<int> Main(string[] args)
    {
        string exePath = @"C:\Users\Griffith\Desktop\hfz_work\HFZ Activator A12+ Premium V1.2\HFZ Activator A12+ Premium.exe";
        string outDir = @"C:\Users\Griffith\Desktop\hfz_work\analysis\extracted";
        int waitSeconds = 35;

        Directory.CreateDirectory(outDir);
        if (!File.Exists(exePath)) { Console.Error.WriteLine("EXE not found"); return 1; }

        Console.WriteLine("[*] Launching HFZ...");
        var proc = Process.Start(new ProcessStartInfo(exePath)
        {
            WorkingDirectory = Path.GetDirectoryName(exePath),
            UseShellExecute = true,
            WindowStyle = ProcessWindowStyle.Normal
        });
        if (proc == null) return 1;

        Console.WriteLine($"[*] PID: {proc.Id} | Waiting {waitSeconds}s...");
        await Task.Delay(waitSeconds * 1000);
        proc.Refresh();
        if (proc.HasExited) { Console.Error.WriteLine("Exited"); return 1; }

        var hProc = proc.Handle;
        Console.WriteLine("[*] Scanning memory for .NET assemblies...");

        // Scan memory regions for MZ headers
        IntPtr addr = IntPtr.Zero;
        int totalMethods = 0;

        while (true)
        {
            if (!VirtualQueryEx(hProc, addr, out var mbi, Marshal.SizeOf<MEMORY_BASIC_INFORMATION>()))
                break;

            if (mbi.State == 0x1000 && (mbi.Protect & 0x02) == 0x02) // MEM_COMMIT + PAGE_READWRITE
            {
                byte[] buf = new byte[Math.Min((int)mbi.RegionSize, 1024 * 1024)];
                if (ReadProcessMemory(hProc, mbi.BaseAddress, buf, buf.Length, out int read) && read > 2)
                {
                    // Scan for PE signatures
                    totalMethods += ScanForPE(buf, mbi.BaseAddress, hProc, outDir);
                }
            }

            addr = mbi.BaseAddress + (int)mbi.RegionSize;
            if ((long)addr >= 0x7FFFFFFF) break;
        }

        Console.WriteLine($"[+] Total methods with IL: {totalMethods}");
        Console.WriteLine($"[+] Output: {outDir}");
        return 0;
    }

    static int ScanForPE(byte[] buf, IntPtr baseAddr, IntPtr hProc, string outDir)
    {
        int found = 0;
        for (int i = 0; i < buf.Length - 0x100; i++)
        {
            // Look for "MZ" header
            if (buf[i] != 0x4D || buf[i + 1] != 0x5A) continue;

            // Read PE offset at offset 0x3C
            int peOffset = BitConverter.ToInt32(buf, i + 0x3C);
            int peAddr = i + peOffset;
            if (peAddr + 0x100 > buf.Length) continue;

            // Check "PE\0\0" signature
            if (buf[peAddr] != 0x50 || buf[peAddr + 1] != 0x45 || buf[peAddr + 2] != 0 || buf[peAddr + 3] != 0) continue;

            // Check if it's a .NET assembly (CLR header)
            ushort machine = BitConverter.ToUInt16(buf, peAddr + 4);
            ushort sections = BitConverter.ToUInt16(buf, peAddr + 6);
            int optHeader = peAddr + 24;
            ushort magic = BitConverter.ToUInt16(buf, optHeader);

            int clrRVA = 0, clrSize = 0;
            if (magic == 0x10B) // PE32
            {
                int dataDir = optHeader + 96;
                clrRVA = BitConverter.ToInt32(buf, dataDir + 208);
                clrSize = BitConverter.ToInt32(buf, dataDir + 212);
            }
            else if (magic == 0x20B) // PE32+
            {
                int dataDir = optHeader + 112;
                clrRVA = BitConverter.ToInt32(buf, dataDir + 208);
                clrSize = BitConverter.ToInt32(buf, dataDir + 212);
            }
            else continue;

            if (clrRVA == 0 || clrSize == 0) continue;

            // Found a .NET assembly! 
            Console.WriteLine($"  Found .NET assembly at 0x{baseAddr + i:X}, CLR header RVA=0x{clrRVA:X}");
            found++;
            break; // One PE per region is enough
        }
        return found;
    }
}
