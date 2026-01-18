<p align="center">
  <img src="https://i.imgur.com/MmamZlQ.png" alt="vinder.logo" />
</p>

# Vinder.Federation.Sdk.Contracts

This project contains the set of contracts (interfaces and data models) for the Vinder Identity Provider SDK. It is designed to allow your application to depend only on abstractions instead of concrete implementations, facilitating the adoption of Clean Architecture patterns.

## Overview

The main idea behind this package is to decouple your application layer from the infrastructure layer. Your business logic can interact with the interfaces defined here (such as `IUsersClient`, `ITenantsClient`, etc.), while the actual implementation of the Vinder SDK, which handles HTTP calls and other details, can be injected into your infrastructure layer.

### Key Benefits

- **Strong Decoupling**: Your domain and application layers do not need a reference to the full SDK, only to the contracts.
- **Testability**: It is easy to mock the interfaces (`IUsersClient`, `IGroupsClient`, etc.) to test your business logic in isolation.
- **Clean Architecture**: Aligns perfectly with the principles of Dependency Inversion, allowing the infrastructure to depend on the application, not the other way around.
- **Simplified Maintenance**: Keeps your application layer lightweight and focused on what matters: the business rules.

## Installation

To install the contracts package in your project, use the NuGet package manager.

```bash
dotnet add package Vinder.Federation.Sdk.Contracts
```

## License

This project is licensed under the terms of the [LICENSE](LICENSE) file.

---

This project is maintained by Vinder.