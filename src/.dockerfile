FROM mcr.microsoft.com/dotnet/sdk:6.0 as build-env
EXPOSE 80
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY ../ ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "testDeploy.dll"]