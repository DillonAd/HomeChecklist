FROM microsoft/dotnet:sdk as build

RUN mkdir /app
WORKDIR /app

COPY . .

RUN mkdir /out
RUN dotnet publish --configuration release --output /out --self-contained --runtime linux-musl-x64

FROM microsoft/dotnet:2.1-runtime-deps-alpine as release

WORKDIR /app
COPY --from=build /out ./
EXPOSE 5000
ENTRYPOINT [ "./HomeChecklist" ]