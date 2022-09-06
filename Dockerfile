FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LM.BlazorServer.csproj", "./"]
RUN dotnet restore "LM.BlazorServer.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "LM.BlazorServer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LM.BlazorServer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LM.BlazorServer.dll"]
