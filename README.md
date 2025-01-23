### To run this api localy you need:
1) Download this repository and navigate to the solution folder
2) Run following commands:
```docker
docker compose up -d
```
And apply database migrations:
```docker
docker exec -it smartapi dotnet /migration/SmartTestTaskKozitski.MigrationTool.dll
```

Then navigate to http://localhost:8080
Use api key : abc12def

SwaggerUI is used by default

Available facility codes: 2001, 2002, 2003, 2004, 2005
Available equipment codes: 1001, 1002, 1003, 1004, 1005
