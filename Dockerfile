# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["SmartTestTaskKozitski.WebApi/SmartTestTaskKozitski.WebApi.csproj", "SmartTestTaskKozitski.WebApi/"]
COPY ["SmartTestTaskKozitski.BLL/SmartTestTaskKozitski.BLL.csproj", "SmartTestTaskKozitski.BLL/"]
COPY ["SmartTestTaskKozitski.DAL/SmartTestTaskKozitski.DAL.csproj", "SmartTestTaskKozitski.DAL/"]
COPY . .
WORKDIR "/src/SmartTestTaskKozitski.WebApi"
RUN dotnet restore "SmartTestTaskKozitski.WebApi.csproj"
RUN dotnet build "SmartTestTaskKozitski.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS migration
WORKDIR /src
COPY ["SmartTestTaskKozitski.MigrationTool/SmartTestTaskKozitski.MigrationTool.csproj", "SmartTestTaskKozitski.MigrationTool/"]
COPY . .
RUN dotnet restore "SmartTestTaskKozitski.MigrationTool/SmartTestTaskKozitski.MigrationTool.csproj"
COPY . .
WORKDIR "/src/SmartTestTaskKozitski.MigrationTool"
RUN dotnet build "SmartTestTaskKozitski.MigrationTool.csproj" -c Release -o /app/migration

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./SmartTestTaskKozitski.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /migration
COPY --from=migration /app/migration .

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SmartTestTaskKozitski.WebApi.dll"]

# Set environment variable for ApiKey
ENV ApiKey=abc12def


