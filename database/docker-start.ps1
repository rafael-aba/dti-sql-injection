$scriptpath = $MyInvocation.MyCommand.Path
$dir = Split-Path $scriptpath
Push-Location $dir

Write-Host "Setting up container" -ForegroundColor Green
docker container stop sqlinjection
docker container rm sqlinjection

docker pull microsoft/mssql-server-linux:2017-latest

Write-Host "Waiting for container to start up..." -ForegroundColor Green
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=@Dtidigital123" --name "sqlinjection" -p 9000:1433 -d microsoft/mssql-server-linux:2017-latest
   
$jb = Start-Job { docker logs -f sqlinjection }
while ($jb.HasMoreData) { 
	Receive-Job $jb -OutVariable output | ForEach-Object { if ($_ -match "Microsoft Corporation") { break } }
}
Stop-Job $jb
Remove-Job $jb

Write-Host "Moving scripts into container" -ForegroundColor Green
docker exec -t sqlinjection mkdir /var/opt/mssql/scripts/
docker cp ./create-db.sql sqlinjection:/var/opt/mssql/scripts/
docker cp ./create-tables.sql sqlinjection:/var/opt/mssql/scripts/
docker cp ./fill-data.sql sqlinjection:/var/opt/mssql/scripts/
docker cp ./delete-tables.sql sqlinjection:/var/opt/mssql/scripts/

Write-Host "Creating database" -ForegroundColor Green
docker exec -t sqlinjection /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P "@Dtidigital123" -i /var/opt/mssql/scripts/create-db.sql 
	
Write-Host "Creating tables" -ForegroundColor Green
docker exec -t sqlinjection /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P "@Dtidigital123" -i /var/opt/mssql/scripts/create-tables.sql 

Write-Host "Inserting mocked data" -ForegroundColor Green
docker exec -t sqlinjection /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P "@Dtidigital123" -i /var/opt/mssql/scripts/fill-data.sql
	
Write-Host "Done." -ForegroundColor Green