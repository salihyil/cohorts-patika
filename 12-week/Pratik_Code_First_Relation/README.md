# Code First Relations Practice Project

A .NET Core Web API project demonstrating Entity Framework Core Code First approach with relationship mappings between entities.

## 🚀 Features

- RESTful API endpoints for Users and Posts
- Entity Framework Core Code First approach
- One-to-Many relationship demonstration
- Data Transfer Objects (DTOs) pattern
- Input validation using Data Annotations
- Swagger/OpenAPI documentation

## 🛠️ Tech Stack

- .NET 8.0
- Entity Framework Core 9.0
- SQL Server
- Swagger/OpenAPI

## 📋 Project Structure

```plaintext
├── Controllers/
│ ├── UsersController.cs
│ └── PostsController.cs
├── Entities/
│ ├── UserEntity.cs
│ └── PostEntity.cs
├── DTOs/
│ ├── UserDto/
│ │ └── UserCreateDto.cs
│ └── PostDto/
│ └── PostCreateDto.cs
```

## 🔄 Entity Relationships

### User Entity

- One-to-Many relationship with Posts
- Properties:
  - Id (Primary Key)
  - Username
  - Email
  - Posts (Navigation Property)

### Post Entity

- Many-to-One relationship with User
- Properties:
  - Id (Primary Key)
  - Title
  - Content
  - UserId (Foreign Key)
  - User (Navigation Property)

## 🚀 Getting Started

1. Clone the repository
2. Update the connection string in `appsettings.json`
3. Run Entity Framework migrations:

```bash
dotnet ef database update
```

4. Run the application:

```bash
dotnet run
```

## 📝 API Endpoints

### Users

- GET `/api/users` - Get all users
- GET `/api/users/{id}` - Get user by ID
- POST `/api/users` - Create new user
- PUT `/api/users/{id}` - Update user
- DELETE `/api/users/{id}` - Delete user

### Posts

- GET `/api/posts` - Get all posts
- GET `/api/posts/{id}` - Get post by ID
- POST `/api/posts` - Create new post
- PUT `/api/posts/{id}` - Update post
- DELETE `/api/posts/{id}` - Delete post

## 🔒 Data Validation

The project implements validation using Data Annotations:

- Username: Required, 3-50 characters
- Email: Required, valid email format
- Post Title: Required, 3-100 characters
- Post Content: Required, minimum 10 characters

## 🛠️ Development

The project uses:

- DTOs for data transfer
- Entity Framework Core for ORM
- SQL Server for database
- Swagger for API documentation

## 📄 License

This project is open source and available under the MIT License.
