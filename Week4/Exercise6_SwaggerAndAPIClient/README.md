# Exercise 6: Swagger / OpenAPI Documentation & API Versioning

## 📌 Problem Statement
Configure Swagger UI to enable testing JWT protected endpoints directly from the browser, enable XML documentation comments, and support API Versioning (`/api/v1/products` vs `/api/v2/products`).

---

## 🛠️ Step-by-Step Configuration

### 1. Swagger Security Definition (`Program.cs`)
```csharp
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Cognizant Inventory API", Version = "v1" });
    
    // Add Bearer Token Authorization definition to Swagger UI
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});
```

### 2. API Versioning Setup
```csharp
builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ReportApiVersions = true;
});
```
