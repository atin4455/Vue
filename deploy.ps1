# 1. 提權邏輯 (確保工作目錄正確)
$currentDir = $PSScriptRoot
if (!([Security.Principal.WindowsPrincipal][Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole]::Administrator)) {
    Start-Process powershell.exe "-NoProfile -ExecutionPolicy Bypass -File `"$PSCommandPath`"" -WorkingDirectory "$currentDir" -Verb RunAs
    exit
}

# 2. 切換到腳本所在目錄
Set-Location -Path $currentDir

# 3. 執行流程
Write-Host "--- Stopping IIS ---" -ForegroundColor Yellow
iisreset /stop

Write-Host "--- Dotnet Publishing ---" -ForegroundColor Green
# 請確保此腳本放在 .csproj 檔案旁邊
dotnet publish -c Release -o "C:\inetpub\wwwroot\Vue"

Write-Host "--- Starting IIS ---" -ForegroundColor Yellow
iisreset /start

Write-Host "--- DONE ---" -ForegroundColor Cyan
Write-Host "Press Enter to close this window..."
Read-Host