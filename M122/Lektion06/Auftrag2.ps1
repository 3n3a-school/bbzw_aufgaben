function Get-LargeFiles ($length)
{
  Get-ChildItem C:\Windows | Where-Object ($_.length -ge $length)
}
