#FROM microsoft/aspnetcore-build AS build-env
FROM microsoft/dotnet:2.1-sdk AS build-env
WORKDIR /source

#COPY WeatherMicroservice.csproj . and restore as distinct layers
COPY *.csproj .
#COPY . ./
RUN dotnet restore

# copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o /out

# build runtime image
#FROM microsoft/aspnetcore
FROM microsoft/dotnet:2.1-aspnetcore-runtime
WORKDIR /out
EXPOSE 80
COPY --from=build-env /out .


ENTRYPOINT ["dotnet", "WeatherMicroservice.dll"]

