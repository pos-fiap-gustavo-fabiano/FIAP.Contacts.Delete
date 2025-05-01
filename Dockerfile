    # FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
    # WORKDIR /app

    # COPY src/FIAP.Contacts.Delete.Consumer/*.csproj ./
    # RUN dotnet restore

    # COPY . ./
    # WORKDIR /app/src/FIAP.Contacts.Delete.Consumer
    # RUN dotnet publish -c Release -o /out

    # FROM mcr.microsoft.com/dotnet/aspnet:8.0
    # WORKDIR /app    

    # COPY --from=build /out .

    # EXPOSE 80
    # EXPOSE 443

    # ENTRYPOINT ["dotnet", "FIAP.Contacts.Delete.Consumer.dll"]

# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0@sha256:8ab06772f296ed5f541350334f15d9e2ce84ad4b3ce70c90f2e43db2752c30f6 AS build
WORKDIR /app

COPY src/FIAP.Contacts.Delete.Consumer/*.csproj ./
RUN dotnet restore

COPY . ./
WORKDIR /app/src/FIAP.Contacts.Delete.Consumer
RUN dotnet publish -c Release -r linux-musl-x64 --self-contained true -o /out

# Etapa final com Alpine
FROM alpine:3.21@sha256:a8560b36e8b8210634f77d9f7f9efd7ffa463e380b75e2e74aff4511df3ef88c
WORKDIR /app
COPY --from=build /out .

# Instalar dependências necessárias
RUN apk add --no-cache icu-libs

# Definir variáveis de ambiente
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
ENV ASPNETCORE_URLS=http://+:8080

EXPOSE 8080
ENTRYPOINT ["./FIAP.Contacts.Delete.Consumer"]
