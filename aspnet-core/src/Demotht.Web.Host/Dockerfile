FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/Demotht.Web.Host/Demotht.Web.Host.csproj", "src/Demotht.Web.Host/"]
COPY ["src/Demotht.Web.Core/Demotht.Web.Core.csproj", "src/Demotht.Web.Core/"]
COPY ["src/Demotht.Application/Demotht.Application.csproj", "src/Demotht.Application/"]
COPY ["src/Demotht.Core/Demotht.Core.csproj", "src/Demotht.Core/"]
COPY ["src/Demotht.EntityFrameworkCore/Demotht.EntityFrameworkCore.csproj", "src/Demotht.EntityFrameworkCore/"]
WORKDIR "/src/src/Demotht.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Demotht.Web.Host", "src/Demotht.Web.Host"]
COPY ["src/Demotht.Web.Core", "src/Demotht.Web.Core"]
COPY ["src/Demotht.Application", "src/Demotht.Application"]
COPY ["src/Demotht.Core", "src/Demotht.Core"]
COPY ["src/Demotht.EntityFrameworkCore", "src/Demotht.EntityFrameworkCore"]
WORKDIR "/src/src/Demotht.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Demotht.Web.Host.dll"]
