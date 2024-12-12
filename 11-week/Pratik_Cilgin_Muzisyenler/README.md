# Crazy Musicians API

A RESTful Web API built with ASP.NET Core 8.0 for managing musicians data.

## Features

- RESTful API endpoints for CRUD operations
- Swagger/OpenAPI documentation
- JSON Patch support for partial updates
- XML documentation included

## Technologies

- ASP.NET Core 8.0
- Swagger/OpenAPI
- Newtonsoft.Json
- Microsoft.AspNetCore.JsonPatch

## Prerequisites

- .NET 8.0 SDK
- Visual Studio 2022 or VS Code

## Getting Started

1. Clone the repository

```bash
git clone https://github.com/yourusername/Pratik_Cilgin_Muzisyenler.git
```

2. Navigate to the project directory

```bash
cd Pratik_Cilgin_Muzisyenler
```

3. Build the solution

```bash
dotnet build
```

4. Run the application

```bash
dotnet run
```

5. Open your browser and navigate to:

- Swagger UI: <https://localhost:7001/swagger>
- API Base URL: <https://localhost:7001/api>

## API Documentation

The API documentation is available through Swagger UI when running the application. You can test all endpoints directly from the Swagger interface.

### Available Endpoints

- GET /api/Musicians - Get all musicians
- GET /api/Musicians/{id} - Get a specific musician
- POST /api/Musicians - Create a new musician
- PUT /api/Musicians/{id} - Update a musician
- PATCH /api/Musicians/{id} - Partially update a musician
- DELETE /api/Musicians/{id} - Delete a musician

## Project Structure

- `Controllers/` - API Controllers
- `Models/` - Data Models
- `Program.cs` - Application startup and configuration

## Configuration

The application uses standard ASP.NET Core configuration with additional setup for:

- Swagger documentation
- XML comments inclusion
- NewtonsoftJson for JSON handling

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request
