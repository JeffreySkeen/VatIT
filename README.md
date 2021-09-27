# VatIT
This is a technical assignment, assigne to me by VatIT

## Description
This is a simple application that contains 4 RESTfull apis to preform basic CRUD operations on simpe TODO object.
If a TODO has the Name "I'm lazy" then the progrom will through and exception.
By default, on application start a single TODO is cached in memory.

#### Schema of TODO object
```JSON
{
  "id": 1,
  "name": "Do Some Work",
  "completed": false
}
```

## Usage instructions
- clone this Repository
- open solution in Visual Studio
- Press f5 to run the application

A browser window, ``https://localhost:8080/ToDo`` should popup automatically. If not you can just navigate to ``https://localhost:8080/ToDo``

## Design Choices and dependencies
I used swaggerUI and postman to help speed up testing.
