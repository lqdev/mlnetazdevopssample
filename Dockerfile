FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY . ./
RUN dotnet restore ModelApi/*.csproj
RUN dotnet publish ModelApi/*.csproj -c release -o out

FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
WORKDIR /app
COPY ModelApi/model.zip .
COPY --from=build /app/ModelApi/out ./
ENTRYPOINT ["dotnet", "ModelApi.dll"]