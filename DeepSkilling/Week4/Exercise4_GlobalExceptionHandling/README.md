# Exercise 4: Global Exception Handling Middleware

## 📌 Problem Statement
Unhandled exceptions in production APIs must never expose raw stack traces. Create custom ASP.NET Core Middleware that catches all unhandled exceptions and returns standardized JSON error responses with proper HTTP 500 status codes.
