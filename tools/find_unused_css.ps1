$cssPath = "CalendarApp\wwwroot\css\app.css"
if (-not (Test-Path $cssPath)) { Write-Error "CSS file not found: $cssPath"; exit 1 }
$css = Get-Content -Raw $cssPath
$matches = [regex]::Matches($css,'\.(?<c>[A-Za-z0-9_-]+)')
$classes = $matches | ForEach-Object { $_.Groups['c'].Value } | Sort-Object -Unique
$files = Get-ChildItem -Recurse -File -Include *.razor,*.cs,*.cshtml,*.html,*.css,*.js | Where-Object { $_.FullName -notmatch '\\bin\\' -and $_.FullName -notmatch '\\obj\\' }
$unused = @()
foreach($c in $classes){
    $pattern = "\b" + [regex]::Escape($c) + "\b"
    $found = $false
    foreach($f in $files){
        if (Select-String -Path $f.FullName -Pattern $pattern -Quiet) {
            $found = $true
            break
        }
    }
    if (-not $found) { $unused += $c }
}
$classes | Out-File classes_all.txt -Encoding utf8
$unused | Out-File classes_unused.txt -Encoding utf8
Write-Output "Classes: $($classes.Count) Unused: $($unused.Count)"
Write-Output "Wrote classes_all.txt and classes_unused.txt"
