# Exercise 2: Model Binding & Validation

## 📌 Problem Statement
Ensure incoming request payloads are properly validated before processing. Implement Data Annotations (`[Required]`, `[StringLength]`, `[Range]`) and a custom validation attribute (`[MinimumPrice]`) on a Data Transfer Object (DTO).

---

## 🛠️ Step-by-Step Implementation

1. **DTO Definition (`CreateProductDto.cs`)**:
   Prevents exposing internal domain models and enforces strict validation rules.

2. **Custom Validation Attribute (`CustomValidationAttribute.cs`)**:
   Validates business logic (e.g. Price must be greater than zero or non-negative for discounted items).

---

## 🧪 Validation Code Example
```csharp
[HttpPost]
public IActionResult PostProduct([FromBody] CreateProductDto dto)
{
    if (!ModelState.IsValid)
    {
        return BadRequest(ModelState); // Automatically handled when [ApiController] is applied
    }
    return Ok("Valid Product Data");
}
```
