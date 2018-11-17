FROM teracy/angular-cli AS build

RUN mkdir /app
WORKDIR /app

COPY . .

RUN npm install
RUN ng build --prod=true --aot=true

FROM nginx AS release

WORKDIR /usr/share/nginx/html
RUN rm *
COPY --from=build /app/dist/HomeChecklist .
