#!/bin/bash
PROJECTS=(
  "./ASafariM.Api/ASafariM.Api.csproj"
  "./ASafariM.Application/ASafariM.Application.csproj"
  "./ASafariM.Infrastructure/ASafariM.Infrastructure.csproj"
  "./ASafariM.Presentation/ASafariM.Presentation.csproj"
  "./ASafariM.Domain/ASafariM.Domain.csproj"
)

for proj in "${PROJECTS[@]}"; do
  if ! dotnet $1 $proj; then
    echo "Failed to execute 'dotnet $1 $proj'"
    exit 1
  fi
  echo "Executed 'dotnet $1 $proj'"
done

echo "All projects processed successfully for 'dotnet $1'."
