## Tools and setup

### Code generators

The generators that we showed in the presentation can be installed with the following commands:

```bash
dotnet tool install -g dotnet-aspnet-codegenerator
dotnet tool install -g dotnet-ef
```

### Database

Use the database from the earlier lab - we have copied the Dockerfile into this repository, and the instructions are the same too;

We have supplied you with a database in a Docker-file. Now, don't worry; we know that you have never used Docker before, but it should be installed on your systems (try to start Docker using Spotlight Search) and you only have to care about two simple commands:

#### Starting the database

```bash
docker-compose up -d
```

This will start the database. The first time you run this command it will take about 1-5 minutes. But then it will be lightning fast.

The credentials for the `sa`-account is found in the `docker-compose.yml`-file.

Once the `docker-compose` command has finished you can use Azure Data Studio (should also be installed on your computers) to access the database with those credentials.

#### Shutting the database down

Note the `-d` in the command above. This means that the docker container will run in the background. You can see it through the Docker client but other than that it's hidden.

But you want to shut the database down. This can be done through:

```bash
docker stop sql-server-db
```

Note that the database is held in the container so when you shut it down the data is gone.

## D. Lab instructions

Build a full web site using the MVC (`dotnet new mvc -n UsersInDbWebEf`) and Entity Framework, utilize the code generators that we showed in the presentations.

You will need to install the following dependencies:

```bash
dotnet add package Microsoft.EntityFrameworkCore.Design --prerelease
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --prerelease
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --prerelease
```
