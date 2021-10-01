<#
  Auftrag2: Funktion mit Param
#>
function Get-LargeFiles ($length)
{
  Get-ChildItem C:\Windows | Where-Object ($_.length -ge $length)
}

<# 
  Result: Null
#>