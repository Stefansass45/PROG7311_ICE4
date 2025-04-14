# 📃 Report
Delegation of Work:

## 👥 Contributions

### Monte
Implemented EF Core
Designed model
Ran scaffolding for controller based on EF Core implementation
Helped write SQL file
Fixed issues with docker files

### Stefan
Made the project file and worked on the different docker files, the sql file and the docker compose file with help from Monte on key parts in the compose file

### Hannah
Designed and created MVC application and implemented CRUD functionality

## 🚩 Challenges

We ran into several issues while using Docker Compose. Initially, there were path mismatches between the actual project folder config and the Dockerfile and Docker Compose configuration, which caused 'no main method' build failures. This sent us on a red herring hunt since we thought it had something to do the type of project we are using. But after some troubleshooting we figured out it was due to the directory structure we were using. 

Once that was sorted, we struggled with SQL Server failing to start due to permission issues with mounted volumes, which was just a result of previously failed deployments. We were able to bypass it with `docker compose down -v`.

Finally, we had an issue with SQL server not accepting connections from the API container. This was a major time sink as it took a while to find out that the SQL container was taking up to two minutes to actually become responsive, which led to a lot of false troubleshooting.

## 👀 Insights

A few key things we learned with this that will help for future deployments:
- The scaffolding in Visual Studio is really good once you have EF core ironed out, so spent time on EF Core
- The COPY command in the docker file uses the relative path on the host with it's path as the root path.
- The reason we do the COPY . . AFTER doing the initial project copy and restore is due because it utilizes dockers cache better, making future redeployments much faster: https://stackoverflow.com/questions/53460002/how-to-use-dotnet-restore-properly-in-dockerfile
- The SQL Server container takes a few minutes to become fully responsive and will report "HEALTHY" before it's internal structures are all operational. Thus, wait a bit after deploying before using it
- We can enable development mode for more verbose errors on ASP.NET : https://stackoverflow.com/questions/54901609/how-to-set-the-environment-of-dotnet-core-in-docker

## 🧭 Instructions

*You must have docker and docker-compose installed on your system*

1. Download the ZIP: https://github.com/Stefansass45/PROG7311_ICE4/archive/refs/heads/main.zip
2. Unzip the file
3. Open a terminal at the root of the folder
3. Run `docker-compose up --build`
4. Access the web platform on http://localhost:5000
5. Profit
