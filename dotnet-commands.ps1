$PROJECTS = @(
  "./ASafariM.Api/ASafariM.Api.csproj",
  "./ASafariM.Application/ASafariM.Application.csproj",
  "./ASafariM.Infrastructure/ASafariM.Infrastructure.csproj",
  "./ASafariM.Presentation/ASafariM.Presentation.csproj",
  "./ASafariM.Domain/ASafariM.Domain.csproj"
)

foreach ($proj in $PROJECTS) {
  if (-Not (dotnet $args[0] $proj)) {
    Write-Error "Failed to execute 'dotnet $args[0] $proj'"
    exit 1
  }
  Write-Host "Executed 'dotnet $args $proj'"
}

Write-Host "All projects processed successfully for 'dotnet $($args[0])'."
