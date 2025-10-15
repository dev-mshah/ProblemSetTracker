# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy csproj and restore dependencies (cached layer)
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and publish
COPY . ./
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:0.0 AS runtime
WORKDIR /app

# Copy published output
COPY --from=build /app/publish .

# Expose port for Render
EXPOSE 80

# Entrypoint
ENTRYPOINT ["dotnet", "LeetCode.Api.dll"]
