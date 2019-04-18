dotnet restore;
dotnet build -c Release;
dotnet pack --no-build -c Release PrimePenguin.CentraSharp/CentraSharp.csproj;

$nupkg = (Get-ChildItem CentraSharp/bin/Release/*.nupkg)[0];

# Push the nuget package to AppVeyor's artifact list.
Push-AppveyorArtifact $nupkg.FullName -FileName $nupkg.Name -DeploymentName "PrimePenguin.CentraSharp.nupkg";