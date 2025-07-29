# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiamos el archivo .csproj desde la subcarpeta
COPY inmobiliaria/inmobiliaria.csproj ./

# Restauramos dependencias
RUN dotnet restore

# Copiamos todo el contenido de la solución
COPY inmobiliaria/. ./

# Publicamos en modo Release
RUN dotnet publish -c Release -o out

# Etapa de runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Puerto de escucha (ajustá si es otro)
EXPOSE 7195

# Comando para ejecutar la app
ENTRYPOINT ["dotnet", "inmobiliaria.dll"]
