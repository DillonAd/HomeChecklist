FROM teracy/angular-cli as build

COPY ./package*.json /app/
WORKDIR /app
RUN npm install

COPY . .

ARG configuration=
RUN npm run build -- --output-path=./dist --configuration $configuration

WORKDIR /app/dist

FROM nginx
COPY --from=build /app/dist/ /usr/share/nginx/html