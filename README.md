# identity



### create database and tables relevant to the identity server

```shell
cd .\IdentityService
```

```shell
dotnet ef migrations add InitialCreate
dotnet ef database update
```
