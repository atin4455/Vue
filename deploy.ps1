# 移除提權邏輯，GitHub Runner 不需要
$currentDir = $PSScriptRoot
Set-Location -Path $currentDir

Write-Host "--- Dotnet Publishing ---" -ForegroundColor Green
# 使用變數來控制輸出路徑，增加彈性
$outputPath = $args[0] -if $args[0] -else "C:\inetpub\wwwroot\Vue"

dotnet publish -c Release -o $outputPath

Write-Host "--- DONE ---" -ForegroundColor Cyan
# 移除 Read-Host，避免 Action 卡死