# Exercise 1: Microservices Design & Bounded Contexts

## 📌 Problem Statement
Identify microservice boundaries for an E-Commerce platform following Domain-Driven Design (DDD). Separate the monolithic system into two autonomous microservices:
1. **Catalog Microservice**: Responsible for product details, pricing, and inventory stock.
2. **Order Microservice**: Responsible for processing customer orders, payments, and order status.

Each service owns its domain models and data store.

---

## 🛠️ Step-by-Step Implementation

1. **Catalog Service (`CatalogController.cs`)**: Running on port `5001`.
2. **Order Service (`OrderController.cs`)**: Running on port `5002`.
