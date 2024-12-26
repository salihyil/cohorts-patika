# Pratik Dependency Injection

## Overview

This project is a .NET 8.0 web application demonstrating dependency injection practices. It includes models, interfaces, and controllers to manage classroom and teacher data.

## Project Structure

- **Program.cs**: Entry point of the application.
- **Models/**: Contains data models like `ClassRoom` and `Teacher`.
- **Interfaces/**: Contains interfaces like `ITeacher`.
- **Controllers/**: Manages HTTP requests and responses.

## Setup Instructions

1. **Install .NET 8.0 SDK**: Ensure you have the .NET 8.0 SDK installed on your machine.
2. **Clone the Repository**: Use `git clone <repository-url>` to clone the project.
3. **Restore Dependencies**: Run `dotnet restore` to install necessary packages.
4. **Build the Project**: Use `dotnet build` to compile the application.
5. **Run the Application**: Execute `dotnet run` to start the web server.

## Dependencies

- **Swashbuckle.AspNetCore**: Version 6.6.2 for API documentation.

## Usage

- Access the application via `http://localhost:<port>`.
- Use Swagger UI for API documentation and testing.

## Contributing

Feel free to fork the repository and submit pull requests for any improvements or bug fixes.

## License

This project is licensed under the MIT License.
