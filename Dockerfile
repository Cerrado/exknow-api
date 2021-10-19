FROM mcr.microsoft.com/dotnet/core/sdk:5.0 as build-env
WORKDIR /app

# always restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy and build with publish settings for 'Release'
COPY . ./
RUN dotnet publish -c Release -o out

# Create runtime IMAGE
FROM mcr.microsoft.com/dotnet/core/sdk:5.0
WORKDIR /app
EXPOSE 80
COPY --from=build-env /app/out .
ENTRYPOINT [ "dotnet","ExchangeAPI.dll" ]