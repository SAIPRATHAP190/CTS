# Exercise 2: API Gateway with Ocelot

## 📌 Problem Statement
Prevent external client applications from communicating directly with individual microservices. Implement an API Gateway pattern using **Ocelot** to act as a single entry point running on port `5000`, routing request paths to internal services.

---

## 🛠️ Step-by-Step Configuration

1. **Routing Configuration (`ocelot.json`)**:
   - `http://localhost:5000/gateway/catalog` -> `http://catalogservice:5001/api/catalog`
   - `http://localhost:5000/gateway/orders` -> `http://orderservice:5002/api/order`

2. **Middleware Registration (`Program.cs`)**:
   `builder.Services.AddOcelot();` and `await app.UseOcelot();`
