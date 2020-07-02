
$ErrorActionPreference = "stop"

Write-Host "Crawling ESI..."
& dotnet .tools\RefDataCrawler\RefDataCrawler.dll crawl --dest ".data" --maxerrors 2000 --progress

Write-Host "Generating code..."
& dotnet .tools\RefDataCrawler\RefDataCrawler.dll gen -dest "src" -source ".data"

