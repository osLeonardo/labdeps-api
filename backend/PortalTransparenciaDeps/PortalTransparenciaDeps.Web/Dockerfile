#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0.4-focal-amd64 AS base
RUN apt update && apt install --allow-unauthenticated -y tzdata locales curl libgdiplus libc6-dev ca-certificates
ENV TIME_ZONE="America/Sao_Paulo"
ENV TZ="America/Sao_Paulo"
ENV LANG="pt_BR.UTF-8"
ENV LANGUAGE="pt_BR:pt"
ENV LC_ALL="pt_BR.UTF-8"
RUN sed -i -e 's/# pt_BR.UTF-8 UTF-8/pt_BR.UTF-8 UTF-8/' /etc/locale.gen
RUN dpkg-reconfigure --frontend=noninteractive locales
RUN locale-gen
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /PortalTransparenciaDeps
COPY ["PortalTransparenciaDeps/PortalTransparenciaDeps.Web/PortalTransparenciaDeps.Web.csproj", "src/PortalTransparenciaDeps.Web/"]
COPY ["PortalTransparenciaDeps/PortalTransparenciaDeps.Infrastructure/PortalTransparenciaDeps.Infrastructure.csproj", "src/PortalTransparenciaDeps.Infrastructure/"]
COPY ["PortalTransparenciaDeps/PortalTransparenciaDeps.SharedKernel/PortalTransparenciaDeps.SharedKernel.csproj", "src/PortalTransparenciaDeps.SharedKernel/"]
COPY ["PortalTransparenciaDeps/PortalTransparenciaDeps.Core/PortalTransparenciaDeps.Core.csproj", "src/PortalTransparenciaDeps.Core/"]
RUN dotnet restore "src/PortalTransparenciaDeps.Web/PortalTransparenciaDeps.Web.csproj"
COPY . .
WORKDIR "/PortalTransparenciaDeps/PortalTransparenciaDeps/PortalTransparenciaDeps.Web"
RUN dotnet build "PortalTransparenciaDeps.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PortalTransparenciaDeps.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PortalTransparenciaDeps.Web.dll"]