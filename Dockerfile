FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /App

COPY . ./

RUN dotnet restore "SistemaBiblioteca.generated.sln"

RUN dotnet build "SistemaBiblioteca.generated.sln" --configuration Release --output /out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
COPY --from=build-env /out .
ENTRYPOINT ["dotnet", "SistemaBiblioteca.dll"]