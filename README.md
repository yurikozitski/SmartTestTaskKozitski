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
