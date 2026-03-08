FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY FlowSign.Domain/FlowSign.Domain.csproj FlowSign.Domain/
COPY FlowSign.Application/FlowSign.Application.csproj FlowSign.Application/
COPY FlowSign.Infrastructure/FlowSign.Infrastructure.csproj FlowSign.Infrastructure/
COPY FlowSign.API/FlowSign.API.csproj FlowSign.API/

RUN dotnet restore FlowSign.API/FlowSign.API.csproj

COPY . .

RUN dotnet publish FlowSign.API/FlowSign.API.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "FlowSign.API.dll"]