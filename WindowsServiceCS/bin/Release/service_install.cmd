echo "Run as Admin"
echo "DZ220814 - add servicename"

InstallUtil /i /ServiceName=DZ_WinService WindowsServiceCS.exe
rem InstallUtil /ServiceName=DZ_WinService /u WindowsServiceCS.exe