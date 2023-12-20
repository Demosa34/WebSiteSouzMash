#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0-preview AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0-preview AS build
WORKDIR /src
COPY ["WebSiteSouzMash.API/WebSiteSouzMash.API.csproj", "WebSiteSouzMash.API/"]
RUN dotnet restore "WebSiteSouzMash.API/WebSiteSouzMash.API.csproj"
COPY . .
WORKDIR "/src/WebSiteSouzMash.API"
RUN dotnet build "WebSiteSouzMash.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebSiteSouzMash.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebSiteSouzMash.API.dll"]