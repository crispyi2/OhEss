dotnet tool install --global dotnet-ef
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet ef migrations add InitialCreate
dotnet ef database update