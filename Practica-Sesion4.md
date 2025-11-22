# Práctica — Sesión 4: Hello API + Arquitectura en Capas

## 🎯 Objetivo

- Crear una Web API mínima en .NET 8.
- Implementar arquitectura por capas:
  - **Domain**
  - **Application**
  - **Infrastructure**
  - **Api**
- Exponer endpoints:
  - `GET /api/health`
  - `GET /api/version`
- Crear pruebas unitarias para:
  - `HealthService`
  - `VersionService`

---

## 🧩 Resumen de pasos realizados

### 1. Crear solución y proyectos

```bash
dotnet new sln -n HelloApi
dotnet new webapi -n HelloApi.Api
dotnet new classlib -n HelloApi.Domain
dotnet new classlib -n HelloApi.Application
dotnet new classlib -n HelloApi.Infrastructure
dotnet new xunit -n HelloApi.Tests
dotnet sln add ./HelloApi.*
```

### 2. Configurar referencias entre capas
```bash
dotnet add HelloApi.Application reference HelloApi.Domain
dotnet add HelloApi.Infrastructure reference HelloApi.Application
dotnet add HelloApi.Api reference HelloApi.Application
dotnet add HelloApi.Api reference HelloApi.Infrastructure
dotnet add HelloApi.Tests reference HelloApi.Infrastructure
dotnet add HelloApi.Tests reference HelloApi.Domain
```
### 3. Crear modelos de dominio

- HealthDto

- VersionDto

### 4. Crear interfaces en Application

- IHealthService

- IVersionService

### 5. Implementar servicios en Infrastructure

- HealthService

- VersionService

### 6. Registrar servicios en Program.cs
```bash
builder.Services.AddScoped<IHealthService, HealthService>();
builder.Services.AddScoped<IVersionService, VersionService>();
```
### 7. Crear controladores

- HealthController

- VersionController

### 8. Probar los endpoints
```bash
GET http://localhost:5064/api/health
GET http://localhost:5064/api/version
```

### 9. Crear pruebas unitarias

- HealthServiceTests

- VersionServiceTests

Ejemplo de ejecución:
```bash
dotnet test HelloApi.sln
```
### 10. Validar pruebas
```bash
Passed!  - Failed: 0, Passed: 2, Skipped: 0, Total: 2
```