# From project example
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS build-env
WORKDIR /app
EXPOSE 80
EXPOSE 443

COPY *.csproj ./
RUN dotnet restore "PlatformService/PlatformService.csproj"

COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "PlatformService.dll"]


## Generated from Rider ##
#FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443
#
#FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
#WORKDIR /src
#COPY ["PlatformService/PlatformService.csproj", "PlatformService/"]
#RUN dotnet restore "PlatformService/PlatformService.csproj"
#COPY . .
#WORKDIR "/src/PlatformService"
#RUN dotnet build "PlatformService.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "PlatformService.csproj" -c Release -o /app/publish /p:UseAppHost=false
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "PlatformService.dll"]
