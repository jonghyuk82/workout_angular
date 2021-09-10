# workout_angular

Personal workout web application with Angular and .net core

# Git setup and config

- git init
- git branch -M main
- git commit -m "Initial commit"
- git remote add origin {git repository url}
- git push -u origin main or git push -u origin main --force

# Create Angular project

- Install Angular CLI and Node globally and create client folder using below

  - ng new client

- When create components using below:

  - ng g c {name}

- When create services using below:
  - ng g s {name}

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
