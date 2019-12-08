FROM mcr.microsoft.com/dotnet/core/sdk:2.2
RUN curl -sL https://deb.nodesource.com/setup_12.x | bash - &&  apt update && apt install -y nodejs
COPY . /app
WORKDIR /app
RUN dotnet -c Release -o ../DatingApp.Dist
WORKDIR /app
EXPOSE 5000
ENTRYPOINT ["dotnet", "DatingApp.API.dll"]
