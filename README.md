# TeamLink


![ModularMonolith drawio (1)](https://github.com/ArturLavrov/TeamLink/assets/10619880/ceb8dc87-8d4d-4d55-b1cc-0b7f392ed90c)



## About

The following application is an example of mudular monolith(or vertical slice) architecture implementation.


## Starting the application

Start API located under Bootstrapper project:

```
cd src/TeamLink.Bootstrapper
dotnet run
```

## Solution structure

### Bootstrapper
Bootstrapper - is a component that responsible for hosting module and it's implementation.

### Modules

**Autonomous modules** with the different set of responsibilities, highly decoupled from each other - there's no reference between the modules at all (such as shared projects for the common data contracts), and the synchronous communication & asynchronous integration (via events) is based on **local contracts** approach.

Each module contains its own HTTP requests definitions file (`.rest`) using [REST Client](https://marketplace.visualstudio.com/items?itemName=humao.rest-client) extension.

### Shared

The set of shared components for the common abstractions & cross-cutting concerns. In order to achieve even better decoupling, it's split into the separate *Abstractions* and *Infrastructure*, where the former does contain public abstractions and the latter their implementation.

## Modular Monolith vs Microservices

## Additional resources
