# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/aspnet:3.1-alpine
COPY bin/Release/netcoreapp3.1/publish/ App/
WORKDIR /App
ENTRYPOINT ["dotnet", "WebApi.dll"]