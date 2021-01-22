
![Dashboard](https://github.com/Buyani/COT-Projects/wwwroot/img/layout.PNG)

# COT Project

#Pending Use Cases(to be intergrated)
1. Register 
2. Login
3. Confirm Email
4. Reset Password
5. And others

COT Project support CRUD operations for cot reports for forex anlysis ,howerver in future more use cases will be added to this project for expand its functionality

# Frameworks - Libraries

1. ASP.NET MVC (version 5)
2. Repository Pattern
2. Entity Framework .Net Core 3.1.0
4. Automapper

# Running Project

- Open the project with Visual Studio 2019
- in `appsettings.json`file change the connection string according to your system.
  ```
    "ConnectionStrings": {
    "CotConnection": "Server=(localdb)\\mssqllocaldb;Database=CotData;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
  ```
- In package manager console run the following commands 
    ```
	-Add-Migration InitialCreate or use any name you like
	-Update-database 
   ```
- Run the project start adding cot reports

#  Not much validation has been done in this project 
