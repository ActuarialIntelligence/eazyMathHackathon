FROM mcr.microsoft.com/dotnet/core/aspnet:2.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.1 AS build
WORKDIR /src
COPY ["SchoolBookKubernetesAPI/SchoolBookKubernetesAPI.csproj", "SchoolBookKubernetesAPI/"]

RUN dotnet restore "SchoolBookKubernetesAPI/SchoolBookKubernetesAPI.csproj"
COPY . .
WORKDIR "/src/SchoolBookKubernetesAPI"
RUN dotnet build "SchoolBookKubernetesAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SchoolBookKubernetesAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SchoolBookKubernetesAPI.dll"]