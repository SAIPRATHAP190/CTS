# Exercise 3: Synchronous Inter-Service HTTP Communication

## 📌 Problem Statement
When creating a new order in `OrderService`, the service must query `CatalogService` synchronously via HTTP to verify that the product exists and has sufficient stock before placing the order.
