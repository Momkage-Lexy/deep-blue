$destDir = "D:\home\site\wwwroot\ms-playwright"
$zipUrl = "https://commondatastorage.googleapis.com/chromium-browser-snapshots/Win_x64/1260712/chrome-win.zip"

Write-Host "Creating directory: $destDir"
New-Item -ItemType Directory -Force -Path $destDir | Out-Null

$tempDir = "D:\home\temp-chromium"
$zipPath = "$tempDir\chrome-win.zip"

Write-Host "Downloading Chromium snapshot..."
New-Item -ItemType Directory -Force -Path $tempDir | Out-Null
Invoke-WebRequest -Uri $zipUrl -OutFile $zipPath

Write-Host "Extracting headless_shell.exe..."
Add-Type -AssemblyName System.IO.Compression.FileSystem
[System.IO.Compression.ZipFile]::ExtractToDirectory($zipPath, $tempDir)

$sourcePath = Join-Path $tempDir "chrome-win\headless_shell.exe"
$targetPath = Join-Path $destDir "headless_shell.exe"

Write-Host "Copying headless_shell.exe to publish folder..."
Copy-Item $sourcePath $targetPath -Force

Write-Host "✅ headless_shell.exe deployed successfully to $destDir"
