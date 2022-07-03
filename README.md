# Stock-App
This app has two main folders

1. API - developed using ASP.NET core
2. UI - developed using ReactJS

## API Setup

1. After cloning, go to **API** folder
    1. Open API Project in visual studio and add *relevant dependancies*
    2. Use `update-database` command to run migrations and seeders
    3. Database name will be `stock-app-db`
2. Run the project
    1. Project will open in <https://localhost:44358/swagger/index.html>
    2. <https://localhost:44358/api/PriceSourceTicker/Generate> API can be used to generate price source values
