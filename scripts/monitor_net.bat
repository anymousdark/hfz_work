@echo off
echo [*] Launching HFZ...
start "" "C:\Users\Griffith\Desktop\hfz_work\HFZ Activator A12+ Premium V1.2\HFZ Activator A12+ Premium.exe"
echo [*] Waiting 60 seconds - monitoring connections...
ping -n 60 127.0.0.1 >nul
echo [*] Collecting connections...
powershell -Command "$p = Get-Process 'HFZ Activator A12+ Premium' -ErrorAction SilentlyContinue; if ($p) { $conns = Get-NetTCPConnection -OwningProcess $p.Id -ErrorAction SilentlyContinue; $conns | Format-Table LocalAddress, LocalPort, RemoteAddress, RemotePort, State -AutoSize; $conns | %{ try { $name = [System.Net.Dns]::GetHostEntry($_.RemoteAddress).HostName; Write-Host ('DNS: '+$_.RemoteAddress+' -> '+$name) } catch {} } } else { Write-Host 'HFZ not running' }" > "C:\Users\Griffith\Desktop\hfz_work\analysis\netlog.txt" 2>&1
type "C:\Users\Griffith\Desktop\hfz_work\analysis\netlog.txt"
echo [*] Done! Log: analysis\netlog.txt
pause
