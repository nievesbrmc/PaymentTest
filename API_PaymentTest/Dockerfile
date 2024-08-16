FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR paymentTest

EXPOSE 80
EXPOSE 4023

COPY ./*.csproj ./
RUN donet restore

COPY . .
RUN donet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/sdk:5.0
WORKDIR /paymentest
COPY --from=build /paymentTest/out .
ENTRYPOINT ["donet", "API_PaymentTest.dll"]