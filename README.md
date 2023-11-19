# TeamLink


![ModularMonolith drawio (1)](https://github.com/ArturLavrov/TeamLink/blob/master/docs/ModularMonolith.drawio%20(2).png)



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

TeamLink project comprises of the following modules:
- Sales
- Delivery


Each module contains its own HTTP requests definitions file (`.rest`) using [REST Client](https://marketplace.visualstudio.com/items?itemName=humao.rest-client) extension.

### Shared

The set of shared components for the common abstractions & cross-cutting concerns. In order to achieve even better decoupling, it's split into the separate *Abstractions* and *Infrastructure*, where the former does contain public abstractions and the latter their implementation.

## Modular Monolith vs Microservices

As always the anseer is it depends.It depends on a verious different aspects of your porojects but speking technocally you could tink about modular architecturure as a pre-microservices step for your solution.

## Additional resources

https://www.youtube.com/watch?v=T-EwN9UqRwE&list=PLdo4fOcmZ0oULyHSPBx-tQzePOYlhvrAU&index=31
