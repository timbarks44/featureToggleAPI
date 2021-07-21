FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["FeatureToggleService/FeatureToggleService.csproj", "FeatureToggleService/"]
RUN dotnet restore "FeatureToggleService/FeatureToggleService.csproj"
COPY . .
WORKDIR "/src/FeatureToggleService"
RUN dotnet build "FeatureToggleService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FeatureToggleService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FeatureToggleService.dll"]