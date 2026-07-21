# Exercise 1: Controller & RESTful Routing

## 📌 Problem Statement
Create an ASP.NET Core 8.0 API Controller for managing an Inventory Product Catalog. The controller must implement standard RESTful HTTP actions (`GET`, `POST`, `PUT`, `DELETE`) with appropriate HTTP status codes (`200 OK`, `201 Created`, `400 BadRequest`, `404 NotFound`, `204 NoContent`).

---

## 🛠️ Step-by-Step Implementation

1. **Model Definition (`Product.cs`)**:
   Represents the product entity with `Id`, `Name`, `Category`, `Price`, and `Stock`.

2. **Controller Implementation (`ProductsController.cs`)**:
   - Uses `[ApiController]` and `[Route("api/[controller]")]`.
   - Action methods:
     - `GET /api/products` - Returns all products (`200 OK`)
     - `GET /api/products/{id}` - Returns product by ID or `404 NotFound`
     - `POST /api/products` - Creates new product and returns `201 CreatedAtAction`
     - `PUT /api/products/{id}` - Updates product details or `400`/`404`
     - `DELETE /api/products/{id}` - Removes product (`204 NoContent`)

---

## 🧪 Verification & Testing
Test endpoints using cURL or Postman:
```bash
# Get all products
curl -X GET https://localhost:7001/api/products

# Create product
curl -X POST https://localhost:7001/api/products \
  -H "Content-Type: application/json" \
  -d '{"name":"Wireless Mouse","category":"Electronics","price":29.99,"stock":100}'
```
