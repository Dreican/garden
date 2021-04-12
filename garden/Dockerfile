FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["garden/garden.csproj", "garden/"]
RUN dotnet restore "garden/garden.csproj"
COPY . .
WORKDIR "/src/garden"
RUN dotnet build "garden.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "garden.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "garden.dll"]
