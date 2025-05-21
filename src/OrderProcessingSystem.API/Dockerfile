# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy everything inside 'src' to container
COPY ./src/ ./src/

# Set working directory to API project
WORKDIR /app/src/OrderProcessingSystem.API

# Restore dependencies
RUN dotnet restore OrderProcessingSystem.API.csproj

# Build and publish
RUN dotnet publish -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "OrderProcessingSystem.API.dll"]
