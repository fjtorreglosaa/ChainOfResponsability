Use the following commands to setup the environment

1. Setup the database using Docker

- Image: docker image pull mcr.microsoft.com/mssql/server:2019-latest
- Volume: docker volume create TestData
- Container: docker container run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Password1*" -v TestData:/var/opt/mssql -p 1433:1433 --name TestServer -d mcr.microsoft.com/mssql/server:2019-latest

2. Identity Database:

- dotnet ef migrations add InitialModel -c ApplicationDBContext -p ChainOfResponsability.Infrastructure -o Migrations
- dotnet ef database update -c ApplicationDBContext -p ChainOfResponsability.Infrastructure

3. Application Database:

- dotnet ef migrations add InitialModel -c ApplicationIdentityDbContext -p ChainOfResponsability.Infrastructure -o IdentityMigrations
- dotnet ef database update -c ApplicationIdentityDbContext -p ChainOfResponsability.Infrastructure
