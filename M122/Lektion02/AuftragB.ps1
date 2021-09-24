$Zahl
$NoExecutions = 0

while ($Zahl -ne 0) {
    if ($NoExecutions -gt 0) {
        $Input = Read-Host "Fuck you enter nzumber"
        if ($Input > 0) {
            // bigger than 0
            $Zahl = $Zahl + $Input
        } elseif (0 > $Input) {
            // smaller then 0
        }
        Write-Host "Current Number" $Zahl
    } else {
    }
    $NoExecutions += 1
}