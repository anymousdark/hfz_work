param(
    [string]$ExePath = "C:\Users\Griffith\Desktop\hfz_work\HFZ Activator A12+ Premium V1.2\HFZ Activator A12+ Premium.exe",
    [string]$DumpDir = "C:\Users\Griffith\Desktop\hfz_work\analysis\dumps"
)

Add-Type -TypeDefinition @"
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

public class MiniDump
{
    [DllImport("dbghelp.dll", SetLastError = true)]
    static extern bool MiniDumpWriteDump(
        IntPtr hProcess,
        int ProcessId,
        IntPtr hFile,
        int DumpType,
        IntPtr ExceptionParam,
        IntPtr UserStreamParam,
        IntPtr CallbackParam);

    public static bool Dump(int pid, string path)
    {
        using (Process p = Process.GetProcessById(pid))
        using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            return MiniDumpWriteDump(
                p.Handle, pid, fs.SafeFileHandle.DangerousGetHandle(),
                2, // MiniDumpWithFullMemory
                IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
        }
    }
}
"@ -ReferencedAssemblies "System.dll"

if (!(Test-Path $DumpDir)) { New-Item -ItemType Directory -Path $DumpDir -Force | Out-Null }

# Launch app
Write-Host "[*] Launching: $ExePath"
Start-Process -FilePath $ExePath -WindowStyle Normal
Write-Host "[*] Waiting 15 seconds..."
Start-Sleep -Seconds 15

$proc = Get-Process -Name "HFZ Activator A12+ Premium" -ErrorAction SilentlyContinue
if (!$proc) {
    $proc = Get-Process | Where-Object { $_.MainModule.FileName -eq $ExePath } | Select-Object -First 1
}
if (!$proc) { Write-Host "[ERROR] Process not found"; exit 1 }

$timestamp = Get-Date -Format "yyyyMMdd-HHmmss"
$dumpFile = "$DumpDir\managed-dump-$timestamp.dmp"
Write-Host "[*] Creating managed dump (PID $($proc.Id)) -> $dumpFile"
if ([MiniDump]::Dump($proc.Id, $dumpFile)) {
    Write-Host "[+] Dump created successfully!"
} else {
    Write-Host "[ERROR] Dump failed (HRESULT: $([Marshal]::GetLastWin32Error()))"
}
