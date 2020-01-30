# https://hub.docker.com/_/microsoft-dotnet-core
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln .
COPY newsg8core/*.csproj ./newsg8core/
RUN dotnet restore

# copy everything else and build app
COPY newsg8core/. ./newsg8core/
WORKDIR /source/newsg8core
RUN dotnet publish -c release -o /app

# final stage/image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "newsg8core.dll"]
