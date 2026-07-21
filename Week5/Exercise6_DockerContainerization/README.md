# Exercise 6: Docker Containerization & Multi-Container Orchestration

## 📌 Problem Statement
Containerize individual microservices using multi-stage `Dockerfile` instances and orchestrate the entire distributed system (Catalog Service, Order Service, Ocelot Gateway, and RabbitMQ) using **Docker Compose**.

---

## 🛠️ Execution Commands
```bash
# Build and spin up all microservices and dependencies
docker-compose up -d --build

# View container logs
docker-compose logs -f

# Shut down multi-container network
docker-compose down
```
