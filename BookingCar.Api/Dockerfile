FROM image-registry.dobrozaim.ru/dotnet/aspnet:8.0 AS base
WORKDIR /app
ENV ASPNETCORE_HTTP_PORTS=80
EXPOSE 80

FROM image-registry.dobrozaim.ru/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/AutoLoanSteps.Api/AutoLoanSteps.Api.csproj", "AutoLoanSteps.Api/"]
RUN dotnet restore "./AutoLoanSteps.Api/AutoLoanSteps.Api.csproj"

COPY ["src", "."]
WORKDIR "/src/AutoLoanSteps.Api"
RUN dotnet build "./AutoLoanSteps.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./AutoLoanSteps.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AutoLoanSteps.Api.dll"]