# Exercise 3: Dependency Injection & Service Lifecycles

## 📌 Problem Statement
Decouple business logic from API Controllers using the Repository / Service Pattern and register services in ASP.NET Core Dependency Injection (DI) Container. Understand Service Lifecycles:
- **Transient**: Created each time requested (`builder.Services.AddTransient<TInterface, TImpl>()`)
- **Scoped**: Created once per HTTP Request (`builder.Services.AddScoped<TInterface, TImpl>()`)
- **Singleton**: Created once for application lifetime (`builder.Services.AddSingleton<TInterface, TImpl>()`)

---

## 🛠️ Step-by-Step Implementation

1. Interface Definition (`IProductService.cs`)
2. Implementation Class (`ProductService.cs`)
3. Registration in Application Builder (`Program.cs`)
