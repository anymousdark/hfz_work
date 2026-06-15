# Self-elevate if not admin
if (-NOT ([Security.Principal.WindowsPrincipal] [Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole]::Administrator))
{
    Write-Host "[*] Requesting admin privileges..."
    Start-Process PowerShell.exe -Verb RunAs -ArgumentList "-NoProfile -ExecutionPolicy Bypass -File `"$PSCommandPath`""
    exit
}

Write-Host "[*] Admin confirmed. Starting dump..."
$hfzdec = "C:\Users\Griffith\Desktop\hfz_work\bin\hfzdec.exe"
$procdump = "C:\Users\Griffith\Desktop\hfz_work\tools\procdump\procdump.exe"
$exe = "C:\Users\Griffith\Desktop\hfz_work\HFZ Activator A12+ Premium V1.2\HFZ Activator A12+ Premium.exe"

# Check if HFZ already running
$proc = Get-Process -Name "HFZ Activator A12+ Premium" -ErrorAction SilentlyContinue
if (!$proc) {
    Write-Host "[*] Launching HFZ Activator..."
    Start-Process -FilePath $exe -WorkingDirectory (Split-Path $exe -Parent) -WindowStyle Normal
    Write-Host "[*] Waiting 35 seconds for decryption..."
    Start-Sleep -Seconds 35
}
else {
    Write-Host "[*] HFZ already running (PID: $($proc.Id))"
}

# Find PID
$proc = Get-Process -Name "HFZ Activator A12+ Premium" -ErrorAction SilentlyContinue
if (!$proc) { Write-Host "[ERROR] HFZ process not found"; exit 1 }

$pid = $proc.Id
$dumpFile = "C:\Users\Griffith\Desktop\hfz_work\analysis\dumps\HFZ_$(Get-Date -Format 'yyyyMMdd-HHmmss').dmp"

Write-Host "[*] Running procdump on PID $pid -> $dumpFile"
& $procdump -ma $pid "`"$dumpFile`"" -accepteula -n 1

if ($LASTEXITCODE -eq 0) {
    $size = (Get-Item $dumpFile).Length / 1MB
    Write-Host "[+] Dump created: $dumpFile ($([math]::Round($size,1)) MB)"
    Write-Host "[*] Next: Open in dnSpy -> File -> Open -> $dumpFile"
}
else {
    Write-Host "[ERROR] procdump failed with exit code $LASTEXITCODE"
}

Write-Host ""
Write-Host "Press any key to exit..."
$null = $Host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")
