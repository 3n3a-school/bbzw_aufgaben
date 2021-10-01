<# 
    Auftrag3: Funktion Param Standardwert
#>

function Get-LargeFiles ($location = "C:\Windows", $length = 1MB)
{
  Get-ChildItem $location | Where-Object ($_.length -ge $length)
}
