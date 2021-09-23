#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["calc/calc.csproj", "calc/"]
RUN dotnet restore "calc/calc.csproj"
COPY . .
WORKDIR "/src/calc"
RUN dotnet build "calc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "calc.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "calc.dll"]