# Permisos y Roles con JWT
Proyecto Backend realizado con .NET Core y C# + JWT para autenticación y autorización de endpoints.

## Modelos
- User
- Country
- Product
- Employee

## Json Web Token + Roles
Existen 2 roles de usuario Administrador y Vendedor, por lo cual los endpoints están de la siguiente manera:
- Country (GET) -> público
- Login (POST) -> público (retorna el token) 
- Product (GET) -> usuarios logeados (requiere token para la autorización)
- Employee (GET) -> usuarios logeados (solo los usuarios con token y rol Administrador tienen acceso)

## Dependencias
- AspNetCore Authentication JwtBearer