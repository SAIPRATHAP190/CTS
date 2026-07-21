# Week 4: ASP.NET Core 8.0 Web API

Welcome to **Week 4** of the Cognizant DeepSkilling Program. This week focuses on building robust, scalable, and secure RESTful Web APIs using **ASP.NET Core 8.0**.

---

## 🎯 Learning Objectives
By completing the exercises in this week, you will learn how to:
1. Design RESTful API endpoints following standard HTTP verbs (`GET`, `POST`, `PUT`, `DELETE`).
2. Utilize **Controllers**, **Action Results**, and **Routing** in ASP.NET Core 8.
3. Apply **Model Binding**, **Data Annotations**, and **Custom Validation**.
4. Implement **Dependency Injection (DI)** with Scoped, Transient, and Singleton lifecycles.
5. Create **Custom Middleware** for Global Exception Handling and Logging.
6. Secure Web APIs using **JWT (JSON Web Token)** Authentication and Role-Based Authorization.
7. Configure **Swagger / OpenAPI** documentation and API Versioning.

---

## 📂 Week 4 Exercises Index

| Exercise | Topic | Key Files / Concepts |
| :--- | :--- | :--- |
| **[Exercise 1](./Exercise1_ControllerAndRouting/)** | Controller & RESTful Routing | `ProductsController.cs`, `Product.cs`, HTTP verbs, Attribute Routing |
| **[Exercise 2](./Exercise2_ModelBindingAndValidation/)** | Model Binding & Validation | `CreateProductDto.cs`, Data Annotations, Custom Attributes |
| **[Exercise 3](./Exercise3_DependencyInjectionAndServices/)** | Dependency Injection & Services | `IProductService.cs`, `ProductService.cs`, Service Lifecycles |
| **[Exercise 4](./Exercise4_GlobalExceptionHandling/)** | Global Exception Middleware | `GlobalExceptionMiddleware.cs`, Standardized Error Responses |
| **[Exercise 5](./Exercise5_JWTAuthenticationAndAuthorization/)** | JWT Auth & Authorization | `AuthController.cs`, `JwtService.cs`, Bearer Tokens |
| **[Exercise 6](./Exercise6_SwaggerAndAPIClient/)** | Swagger Documentation | `Program.cs`, OpenAPI schema, XML Comments |

---

## 🚀 How to Run Exercises
1. Ensure **.NET 8.0 SDK** is installed on your machine.
2. Open terminal in any exercise directory and run:
   ```bash
   dotnet run
   ```
3. Open browser or Postman at `https://localhost:7001/swagger` to inspect and test endpoints.