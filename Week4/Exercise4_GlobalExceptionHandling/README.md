# Exercise 4: Global Exception Handling Middleware

## 📌 Problem Statement
Unhandled exceptions in production APIs must never expose raw stack traces or crash application processes. Create custom ASP.NET Core Middleware that catches all unhandled exceptions and returns standardized JSON error responses with proper HTTP 500 status codes.

---

## 🛠️ Step-by-Step Implementation

1. **Error Details Model (`ErrorDetails.cs`)**:
   Formats uniform API responses: `StatusCode`, `Message`, `TraceId`, and `Timestamp`.

2. **Custom Exception Middleware (`GlobalExceptionMiddleware.cs`)**:
   Intercepts HTTP pipeline requests via `RequestDelegate next` and wraps execution in `try-catch`.

3. **Registration**:
   `app.UseMiddleware<GlobalExceptionMiddleware>();` in `Program.cs`.
