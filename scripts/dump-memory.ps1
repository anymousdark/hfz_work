param(
    [string]$ExePath = "C:\Users\Griffith\Desktop\hfz_work\HFZ Activator A12+ Premium V1.2\HFZ Activator A12+ Premium.exe",
    [string]$AppName = "HFZ Activator A12+ Premium",
    [string]$DumpDir = "C:\Users\Griffith\Desktop\hfz_work\analysis\dumps"
)

if (!(Test-Path $DumpDir)) { New-Item -ItemType Directory -Path $DumpDir -Force | Out-Null }

$ProcDump = "C:\Users\Griffith\Desktop\hfz_work\tools\procdump\procdump.exe"
if (!(Test-Path $ProcDump)) {
    Write-Host "[ERROR] ProcDump not found at $ProcDump"
    exit 1
}

# Launch the app
Write-Host "[*] Launching: $ExePath"
Start-Process -FilePath $ExePath -WindowStyle Normal

Write-Host "[*] Waiting 15 seconds for method decryption..."
Start-Sleep -Seconds 15

# Find the process
$proc = Get-Process -Name "HFZ Activator A12+ Premium" -ErrorAction SilentlyContinue
if (!$proc) {
    # Fallback: try to find any process from that dir
    $proc = Get-Process | Where-Object { $_.MainModule.FileName -eq $ExePath -or $_.Name -like "*HFZ*" } | Select-Object -First 1
}
if (!$proc) {
    Write-Host "[ERROR] Process not found. Check if app is running."
    exit 1
}

$pid = $proc.Id
Write-Host "[*] Found PID: $pid"

# Create full memory dump
$timestamp = Get-Date -Format "yyyyMMdd-HHmmss"
$dumpFile = "$DumpDir\$AppName-$timestamp.dmp"
Write-Host "[*] Creating full memory dump -> $dumpFile"
& $ProcDump -ma $pid $dumpFile -accepteula 2>&1

Write-Host "[*] Dump complete. Open in dnSpy: File -> Open -> '$dumpFile'"
