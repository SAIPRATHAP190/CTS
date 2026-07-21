# Exercise 5: Asynchronous Event-Driven Messaging with RabbitMQ

## 📌 Problem Statement
Replace synchronous HTTP coupling with asynchronous event publishing. When `OrderService` places a new order, it publishes an `OrderCreatedEvent` message to a **RabbitMQ** exchange. `CatalogService` subscribes to this exchange and automatically decrements stock levels.
