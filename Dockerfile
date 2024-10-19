FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS base
USER app
WORKDIR /app

#HTTP
EXPOSE 5187

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Pedidos.API/Pedidos.API.csproj", "src/Pedidos.API/"]
COPY ["src/Modules/Common/Pedidos.Common/Pedidos.Common.csproj", "src/Modules/Common/Pedidos.Common/"]
COPY ["src/Modules/Pedido/Pedidos.Pedido.Application/Pedidos.Pedido.Application.csproj", "src/Modules/Pedido/Pedidos.Pedido.Application/"]
COPY ["src/Modules/Pedido/Pedidos.Pedido.Domain/Pedidos.Pedido.Domain.csproj", "src/Modules/Pedido/Pedidos.Pedido.Domain/"]
COPY ["src/Modules/Pedido/Pedidos.Pedido.Infrastructure/Pedidos.Pedido.Infrastructure.csproj", "src/Modules/Pedido/Pedidos.Pedido.Infrastructure/"]
COPY ["src/Modules/Checkout/Pedidos.Checkout.Application/Pedidos.Checkout.Application.csproj", "src/Modules/Checkout/Pedidos.Checkout.Application/"]
COPY ["src/Modules/Checkout/Pedidos.Checkout.Infrastructure/Pedidos.Checkout.Infrastructure.csproj", "src/Modules/Checkout/Pedidos.Checkout.Infrastructure/"]
RUN dotnet restore "./src/Pedidos.API/Pedidos.API.csproj"
COPY . .
WORKDIR "/src/src/Pedidos.API"
RUN dotnet build "./Pedidos.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Pedidos.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENV ASPNETCORE_URLS=http://+:5187

ENTRYPOINT ["dotnet", "Pedidos.API.dll"]