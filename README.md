# BasketApp
 A basket API application developed with .Net Core
 
* When you run the project, a database will be created and data will be inserted. The server name is given as "localhost" in connectionString in the appsettings.json file. If your SQL Server version does not support this local server name, replace it with your local server name.
* You can access the Postman document link via the following url.
  * https://documenter.getpostman.com/view/5753366/TzRX7kEe
* You can also access the Postman collection via the document, and you can also access it via the collection url below.
  * https://www.getpostman.com/collections/ecf2eab8963f7352d410
* In the project, customer, product, stock and basket controls were made and the product was added to the basket.

## Endpoints:
* GET /customers
* GET /customers/{customerId}
* GET /products
* GET /products/{productVariantId}
* GET /basket/{customerId}
* POST /basket



## Technologies and approaches used

* .Net Core
* Entity Framework Core
* DAPPER
* Code First
* MSSQL
* Dependency Injection
* DDD
* SOLID
* OOP
* Clean Code


## Solution Structure

* BasketApp.API
* BasketApp.Data
* BasketApp.Domain

## Database Design

![Basket_Db](https://user-images.githubusercontent.com/37457080/118396941-761f3280-b65a-11eb-836b-fbc0be03c812.png)


