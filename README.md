# DVLD System — Windows Forms Desktop Application

A Windows Forms desktop application for managing driving license operations. The application communicates with separate backend and authentication APIs to handle licensing workflows, user authentication, and related administrative operations.

## Overview

DVLD System is the desktop client of a Driving & Vehicle License Management System. It provides a graphical user interface for managing people, users, drivers, license applications, tests, and license-related operations.

The solution follows a multi-project structure that separates the Windows Forms user interface, application services, and infrastructure components.

## Features

- **Authentication:** Login and automatic login support.
- **People Management:** Manage people and view personal information.
- **User Management:** Manage users and user-related operations.
- **Application Management:** Manage application types and local driving license applications.
- **Driver Management:** View and manage driver records.
- **Test Management:** Schedule test appointments, manage test types, and record test results.
- **License Management:** Handle license issuance, renewal, replacement, and license information.
- **International Licenses:** Manage international license applications and related information.
- **Detained Licenses:** Support license detention and release workflows.

## Technologies Used

- C#
- .NET 10
- Windows Forms (WinForms)
- Microsoft.Extensions.DependencyInjection
- HttpClient and HTTP/JSON APIs
- Guna.UI2.WinForms
- Krypton Toolkit

## Architecture

The solution consists of three projects:

| Project | Responsibility |
|---|---|
| `DVLD.WinForms` | Desktop user interface, forms, and user interactions. |
| `DVLD.Application` | Application services, DTOs, enums, and interfaces. |
| `DVLD.Infrastructure` | HTTP communication, API clients, authentication-related components, and supporting services. |

### Application Flow

The desktop application communicates with two separate services:

- **DVLDApi:** Handles the main driving license management operations.
- **AuthApi:** Handles authentication-related operations.

The application uses dedicated API clients to send HTTP requests and exchange JSON data with these services. JWT access tokens are attached to protected requests where required.

Dependency injection is used to register application services, API clients, and Windows Forms components.

## Related Projects

- [DVLDApi — Backend API](https://github.com/HaiderMohammed7/DVLD-API)
- [AuthApi — Authentication Service](https://github.com/HaiderMohammed7/Auth-Service-API)

## Prerequisites

Before running the application, make sure you have:

- Windows
- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- Visual Studio with the .NET desktop development workload
- A running and configured instance of DVLDApi
- A running and configured instance of AuthApi

Both APIs must be configured to use the appropriate databases and application settings.

## Configuration

The current API clients use the following local HTTPS addresses:

| Service | Base URL |
|---|---|
| DVLDApi | `https://localhost:7237/` |
| AuthApi | `https://localhost:7011/` |

These URLs are currently defined in the API client implementations. If your local API instances use different addresses or ports, update the corresponding `BaseAddress` values in `DVLDApiClient` and `AuthApiClient`.

Ensure that the local HTTPS development certificates are trusted and that both APIs are accessible before running the desktop application.

For backend database configuration and migration instructions, see the [DVLDApi repository](https://github.com/HaiderMohammed7/DVLD-API).

## Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/HaiderMohammed7/DVLD-System.git
cd DVLD-System
```

### 2. Restore Dependencies

Open `DVLDSystem.slnx` in Visual Studio and restore the NuGet packages.

Alternatively, run the following command from the solution directory:

```bash
dotnet restore
```

### 3. Start the Backend Services

Configure and run both DVLDApi and AuthApi. Ensure that their URLs match the addresses configured in the desktop application's API clients.

Follow the setup instructions in the respective API repositories.

### 4. Run the Desktop Application

Open `DVLDSystem.slnx` in Visual Studio, set `DVLD.WinForms` as the startup project, and run the application.

The application attempts automatic login first and displays the login form when necessary.

## Author

**Haider Mohammed Hameid**

- [GitHub](https://github.com/HaiderMohammed7)
- [LinkedIn](https://www.linkedin.com/in/haider-mohammed-3342381b4/)