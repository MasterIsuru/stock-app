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
    3. Tests can be run by right click on `StockApp.Test` and `Run tests`
    
## UI Setup

1. Go to **UI** folder
    1. Install npm dependencies using `npm i` command
    2. Change `.env` file if the API is not running on <https://localhost:44358>
    3. Start the project using `npm start` command
    4. UI project can be build using `npm run build` command
2. To run the tests, following commands can be used
    1. `npm test` - run the tests in UI components
    2. `npm run test:coverage` - get the coverage report
