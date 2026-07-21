# Exercise 5: JWT Authentication & Authorization

## 📌 Problem Statement
Secure API endpoints using JSON Web Tokens (JWT). Users authenticate at `POST /api/auth/login`, receive a signed JWT token, and present it in HTTP headers: `Authorization: Bearer <TOKEN>` to access protected endpoints tagged with `[Authorize]`.

---

## 🛠️ Step-by-Step Implementation

1. **Token Generation (`JwtService.cs`)**:
   Claims embedded: `UserId`, `Username`, `Role`, Expiration.

2. **Auth Controller (`AuthController.cs`)**:
   `POST /api/auth/login` checks credentials and returns bearer token.

3. **Protection**:
   Apply `[Authorize(Roles = "Admin")]` on sensitive controllers or actions.
