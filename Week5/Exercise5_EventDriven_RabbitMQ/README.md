# Exercise 5: Asynchronous Event-Driven Messaging with RabbitMQ

## 📌 Problem Statement
Replace synchronous HTTP coupling with asynchronous event publishing. When `OrderService` places a new order, it publishes an `OrderCreatedEvent` message to a **RabbitMQ** exchange. `CatalogService` subscribes to this exchange and automatically decrements stock levels upon receipt.

---

## 🛠️ Architecture Flow
1. **OrderService (Publisher)** -> `Publish(OrderCreatedEvent)` -> **RabbitMQ Exchange (`order_events`)**
2. **RabbitMQ Queue (`catalog_order_queue`)** -> **CatalogService (Consumer)** -> `Handle(OrderCreatedEvent)`
