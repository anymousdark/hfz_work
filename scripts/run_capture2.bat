@echo off
echo [*] Starting HFZ...
start "" /B "C:\Users\Griffith\Desktop\hfz_work\HFZ Activator A12+ Premium V1.2\HFZ Activator A12+ Premium.exe"
echo [*] HFZ launched, waiting 10 seconds...
ping -n 10 127.0.0.1 >nul

echo [*] Getting HFZ PID...
for /f "tokens=2" %%a in ('tasklist ^| findstr "HFZ"') do set HFZPID=%%a
echo HFZ PID: %HFZPID%

echo [*] Capturing connections via PowerShell...
powershell -Command "$i=0; while($i -lt 30) { Get-NetTCPConnection -OwningProcess %HFZPID% -ErrorAction SilentlyContinue | Where-Object RemoteAddress -ne '0.0.0.0' | Select-Object LocalAddress,LocalPort,RemoteAddress,RemotePort,State | Export-Csv -Path 'C:\Users\Griffith\Desktop\hfz_work\analysis\connections.csv' -Append -NoTypeInformation; Start-Sleep -Seconds 2; $i++ }"

echo [*] Done!
pause
