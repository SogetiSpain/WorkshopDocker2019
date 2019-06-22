FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY /Sogeti.WSDocker2019.ComposeService/Sogeti.WSDocker2019.ComposeService.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish  ./Sogeti.WSDocker2019.ComposeService/Sogeti.WSDocker2019.ComposeService.csproj -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app
COPY --from=build-env /app/Sogeti.WSDocker2019.ComposeService/out/ .
ENTRYPOINT ["dotnet", "Sogeti.WSDocker2019.ComposeService.dll"]