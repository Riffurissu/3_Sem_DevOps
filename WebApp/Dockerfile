# ������������������ ������ �������� ��� ��������� ������������ ���������� webapp � docker-compose:
#
# webapp:
#    build:
#       context: .
#       dockerfile: ./WebApp/Dockerfile
#    <������ ���������>
#
# ������������������� ������ �������� ��� ������������:
#
# webapp:
#    build:
#       context: ./WebApp
#       dockerfile: ./Dockerfile
#    <������ ���������>

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8111

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
# COPY ["WebApp/WebApp.csproj", "WebApp/"]
# RUN dotnet restore "./WebApp/WebApp.csproj"
COPY ["./WebApp.csproj", "./"]
RUN dotnet restore "WebApp.csproj"
COPY . .
# WORKDIR "/src/WebApp"
# RUN dotnet build "./WebApp.csproj" -c %BUILD_CONFIGURATION% -o /app/build
WORKDIR "/src/"
RUN dotnet build "WebApp.csproj" -c %BUILD_CONFIGURATION% -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
# RUN dotnet publish "./WebApp.csproj" -c %BUILD_CONFIGURATION% -o /app/publish /p:UseAppHost=false
RUN dotnet publish "WebApp.csproj" -c %BUILD_CONFIGURATION% -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApp.dll"]