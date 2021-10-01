<#
    Auftrag5: Funktion mit Return
    @3n3a
#>

function Get-MReturn
{
    $var = 100
    return $var
}

$vv = Get-MReturn
Write-Host "Variable vv: " $vv

<# 
    Result: Variable vv: 100
#>