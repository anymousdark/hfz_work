param([int]$WaitSeconds = 60)

$exe = "C:\Users\Griffith\Desktop\hfz_work\HFZ Activator A12+ Premium V1.2\HFZ Activator A12+ Premium.exe"

Write-Host "[*] Launching HFZ..."
Start-Process -FilePath $exe -WorkingDirectory (Split-Path $exe) -WindowStyle Normal
Start-Sleep -Seconds 3

$proc = Get-Process -Name "HFZ Activator A12+ Premium" -ErrorAction SilentlyContinue
if (!$proc) { Write-Host "[ERROR] HFZ not running"; exit 1 }

$pid = $proc.Id
Write-Host "[*] PID: $pid | Monitoring connections for ${WaitSeconds}s..."
Write-Host ""

$logFile = "C:\Users\Griffith\Desktop\hfz_work\analysis\connections_$(Get-Date -Format 'yyyyMMdd-HHmmss').txt"
$knownConns = @{}

for ($i = 0; $i -lt $WaitSeconds; $i++) {
    $conns = Get-NetTCPConnection -OwningProcess $pid -ErrorAction SilentlyContinue
    foreach ($c in $conns) {
        $key = "$($c.LocalAddress):$($c.LocalPort)->$($c.RemoteAddress):$($c.RemotePort)"
        if (!$knownConns.ContainsKey($key)) {
            $knownConns[$key] = $true
            $line = "[$(Get-Date -Format 'HH:mm:ss')] $key  State=$($c.State)  OwningProcess=$pid"
            Write-Host "  $line"
            Add-Content -Path $logFile -Value $line
        }
    }
    Start-Sleep -Seconds 1
}

Write-Host ""
Write-Host "[+] Log saved: $logFile"
Write-Host "[+] Unique connections: $($knownConns.Count)"

# Also show DNS resolutions
Write-Host ""
Write-Host "[*] DNS resolutions:"
$conns = Get-NetTCPConnection -OwningProcess $pid -ErrorAction SilentlyContinue | Where-Object { $_.RemoteAddress -ne "0.0.0.0" -and $_.RemoteAddress -ne "::" }
$ips = $conns | Select-Object -ExpandProperty RemoteAddress -Unique
foreach ($ip in $ips) {
    try { $name = [System.Net.Dns]::GetHostEntry($ip).HostName } catch { $name = "[unknown]" }
    Write-Host "  $ip -> $name"
    Add-Content -Path $logFile -Value "DNS: $ip -> $name"
}
