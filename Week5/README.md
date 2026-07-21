# Week 5: Microservices Architecture using ASP.NET Core Web API

Welcome to **Week 5** of the Cognizant DeepSkilling Program. This week focuses on designing, building, and deploying decentralized, scalable **Microservices Architectures** using **ASP.NET Core 8.0**, **API Gateway (Ocelot)**, **Polly Resiliency**, **RabbitMQ Event Messaging**, and **Docker Containers**.

---

## 🏗️ Architecture Overview

```
                        +-----------------------+
                        |     Client / Web      |
                        +-----------+-----------+
                                    |
                                    v
                        +-----------------------+
                        |  API Gateway (Ocelot) |
                        |     Port: 5000        |
                        +---+---------------+---+
                            |               |
              +-------------+               +-------------+
              | (HTTP / REST)                             | (HTTP / REST)
              v                                           v
  +-----------------------+                   +-----------------------+
  |  Catalog Microservice |                   |   Order Microservice  |
  |      Port: 5001       |                   |      Port: 5002       |
  +-----------+-----------+                   +-----------+-----------+
              |                                           |
              |                                           |
              +-------------------+   +-------------------+
                                  |   |
                                  v   v
                      +-----------------------+
                      |   RabbitMQ Event Bus  |
                      |     Port: 5672        |
                      +-----------------------+
```

---

## 🎯 Learning Objectives
By completing the exercises in this week, you will learn how to:
1. Decompose monolithic systems into autonomous microservices based on **Domain-Driven Design (DDD)** bounded contexts.
2. Build an **API Gateway using Ocelot** for central routing, rate limiting, and authentication.
3. Perform **Synchronous Inter-Service Communication** using typed `HttpClient` & `IHttpClientFactory`.
4. Implement **Fault Tolerance and Resiliency** (Retry, Circuit Breaker) using **Polly**.
5. Build **Asynchronous Event-Driven Architectures** using **RabbitMQ / MassTransit**.
6. Containerize microservices and orchestrate multi-container environments using **Docker & Docker Compose**.

---

## 📂 Week 5 Exercises Index

| Exercise | Topic | Key Files / Concepts |
| :--- | :--- | :--- |
| **[Exercise 1](./Exercise1_MicroservicesDesign/)** | Service Boundaries & Design | `CatalogController.cs`, `OrderController.cs`, Independent Databases |
| **[Exercise 2](./Exercise2_APIGateway_Ocelot/)** | API Gateway Routing | `ocelot.json`, `Program.cs`, Upstream & Downstream paths |
| **[Exercise 3](./Exercise3_InterServiceCommunication_HttpClient/)** | Synchronous REST Communication | `CatalogHttpClient.cs`, Service-to-Service HTTP calls |
| **[Exercise 4](./Exercise4_ResiliencyWithPolly/)** | Resiliency & Fault Tolerance | `ResiliencePolicies.cs`, Polly Retry & Circuit Breaker |
| **[Exercise 5](./Exercise5_EventDriven_RabbitMQ/)** | Asynchronous Event Messaging | `OrderCreatedEvent.cs`, `RabbitMqEventBus.cs`, Publish/Subscribe |
| **[Exercise 6](./Exercise6_DockerContainerization/)** | Docker & Container Orchestration | `Dockerfile`, `docker-compose.yml`, Multi-container deployment |

---

## 🚀 How to Run Exercises
1. Ensure **Docker Desktop** is running.
2. Navigate to `Exercise6_DockerContainerization` and execute:
   ```bash
   docker-compose up --build
   ```
3. Test endpoints via API Gateway at `http://localhost:5000`.
