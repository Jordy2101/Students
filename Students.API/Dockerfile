#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Students.Api/Students.Api.csproj", "Students.Api/"]
RUN dotnet restore "Students.Api/Students.Api.csproj"
COPY . .
WORKDIR "/src/Students.Api"
RUN dotnet build "Students.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Students.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Students.Api.dll"]