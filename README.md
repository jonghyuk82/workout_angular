# workout_angular

Personal workout web application with Angular and .net core

# Git setup and config

- git init
- git branch -M main
- git commit -m "Initial commit"
- git remote add origin {git repository url}
- git push -u origin main or git push -u origin main --force

# Make https to work

- type below command in backend fonder
- dotnet dev-certs https --trust

# CORS setup

- This is connect front(Angular = localhost:4200) and back(.net core = localhost:5001)
- in Startup.cs file: Add code as services.AddCors() in ConfigureServices section
- in Configure section in Startup.cs file: ordering is important. It has to be between UseRouting and UseEndpoints. Also above the UseAuthorization.
- Add code: app.UseCors()

# Create Angular project

- Install Angular CLI and Node globally and create client folder using below

  - ng new client
  - if Angular asks about Strict Mode, select No

- When create components using below:

  - ng g c {name}

- When create services using below:
  - ng g s {name}

# Adding bootstrap and font-awesome in the project

- go to frontend folder(client) and type below or go to https://valor-software.com/ngx-bootstrap/#/documentation#getting-started

  - ng add ngx-bootstrap

- in frontend folder(client) type below:
  - npm install font-awesome

# launchSettings.json setup

- launchBrowser under API should be set to false

# setup DB and create migration

- Connection String
  - set connection string on appsettings.Development.json
  - apply connection string on Startup.cs
- Getting donnet-ef
  - go to nuget.org and search dotnet-ef
  - install dotnet-ef via typing cli on terminal
- Create Migration
  - type : dotnet ef migrations add InitialCreate -o {path}
  - ex: dotnet ef migrations add InitialCreate -o Data/Migrations
- Create DB
  - type : dotnet ef database update
