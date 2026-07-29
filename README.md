# Kitchos

Aplicación web de gestión de recetas, planificación de comidas y lista de compras.

## Stack

- **.NET 10** (ASP.NET Core MVC)
- **MySQL / MariaDB** con Entity Framework Core
- **Clean Architecture** (Domain, Infrastructure, Web)
- **ASP.NET Core Identity** (autenticación y roles)

## Arquitectura

```
Kitchos.Domain         → Entidades, interfaces de repositorios
Kitchos.Infrastructure → DbContext, repositorios, migraciones, seed data
Kitchos.Web            → Controladores, vistas, Identity UI
```

## Requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- MySQL 8+ o MariaDB 10.5+

## Configuración

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/esam-dev/Kitchos.git
   cd Kitchos
   ```

2. Configurar la conexión a MySQL en `Kitchos.Web/appsettings.Development.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "server=localhost;port=3306;database=kitchos_dev;user=root;password=;"
   }
   ```

3. Ejecutar la aplicación:
   ```bash
   dotnet run --project Kitchos.Web
   ```

   La primera ejecución crea la base de datos y la seed data automáticamente.

## Branches

| Rama | Propósito |
|------|-----------|
| `main` | Producción |
| `develop` | Integración |
| `feature/*` | Desarrollo de funcionalidades |

## Roadmap

Ver [ROADMAP.md](ROADMAP.md) para el plan completo de desarrollo.

## Licencia

MIT
