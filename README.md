# .Net Core Web Api JWT Authentication and swagger

## 1. Configuration

When application run, first of all we set the configuration via  `appsettings.json`. After that, if you have special environment variable, we set them all too.


### 1. AppSettings.json

`appsettings.json`
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=jwtexample;Uid=xxx;Pwd=xxx;"
  },
  "JWTSecretKey": "MySuperSecureKey",
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

## 2. Run

```
$ cd JWTExample
$ dotnet restore
$ dotnet watch run
```

## Tool Set

* Asp.Net Core 2.2
* ASP.NET Core Identity
* Entity Framework Core 2.2
* MySql
* Swagger