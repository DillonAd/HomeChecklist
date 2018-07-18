FROM microsoft/dotnet:sdk AS build
WORKDIR /app

# Copy everything else and build
COPY . /app/

ARG configuration=Debug
RUN dotnet publish -o out -c $configuration

# Build runtime image
FROM microsoft/dotnet:aspnetcore-runtime
WORKDIR /app
COPY --from=build /app/HomeChecklist/out .
ENTRYPOINT ["dotnet", "HomeChecklist.dll"]
