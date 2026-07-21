# Exercise 4: Resiliency & Fault Tolerance with Polly

## 📌 Problem Statement
Network transient faults or temporary downtime in downstream microservices must not cause cascading failures. Implement fault-tolerance resiliency patterns using **Polly**:
1. **Retry Policy**: Retries failed HTTP calls 3 times with exponential backoff (2s, 4s, 8s).
2. **Circuit Breaker Policy**: Opens circuit if 5 consecutive failures occur within 30 seconds, blocking traffic to downstream service for 15 seconds to allow recovery.

---

## 🛠️ Code Implementation
Registered with `HttpClient` builder in `Program.cs`.
