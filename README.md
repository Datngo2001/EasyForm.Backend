# Migrate database

1. Install dotnet tool "dotnet-ef" (one time for each PC)

```
dotnet tool install --global dotnet-ef
```

2. Update connection string to appsetting.json

3. Open terminal at project EasyForm.Api

4. Add new database version (if any data model change)

```
dotnet ef migrations add <Your_Migration_Name> --project ..\EasyForm.Infrastructure\EasyForm.Infrastructure.csproj --output-dir ./Database/Migrations
```

5. Execute migration

```
dotnet ef database update --project ..\EasyForm.Infrastructure\EasyForm.Infrastructure.csproj
```

6. Remove migration to undo migration

```
dotnet ef migrations remove --project ..\EasyForm.Infrastructure\EasyForm.Infrastructure.csproj
```
