# ASP.NET Core MVC Tutorial App

[![View Live Demo](https://img.shields.io/badge/LIVE%20DEMO-blue?style=for-the-badge&logo=windows)](https://chasefranklinaspcoremvctutorial.azurewebsites.net/)

## Overview
A learning project that demonstrates building, validating, and deploying an ASP.NET Core MVC web application using full CRUD functionality and Razor view templates. Deployed via Microsoft Azure App Service.

## Live Demo
[https://chasefranklinaspcoremvctutorial.azurewebsites.net](https://chasefranklinaspcoremvctutorial.azurewebsites.net)

## Technologies Used
- ASP.NET Core MVC (.NET 9+)
- C# / Razor Pages
- Entity Framework Core
- Bootstrap 4/5 for styling
- Microsoft Azure App Service (deployment)
- SCSS, JavaScript, HTML, CSS

## Features
- Full **CRUD functionality** for managing items
- **Razor views** for dynamic page rendering
- **Form validation** using Data Annotations
- **Model binding** and routing via controllers
- Responsive layout using **Bootstrap**
- Deployment pipeline to **Azure App Service**

## Prerequisites

- [.NET 9.0 SDK or later](https://dotnet.microsoft.com/download)
- Visual Studio 2022 (or [Visual Studio Code](https://code.visualstudio.com/))
- (Optional) Azure account for deployment

## Getting Started

To run the project locally:

```bash
git clone https://github.com/tylerchasefranklin/ASP_NET_Core_MVC_Tutorial_App.git
cd ASP_NET_Core_MVC_Tutorial_App
dotnet restore
dotnet run
```

Then go to https://localhost:5001 in your browser.

## Configuration

- Local settings are in `appsettings.json`.
- For secrets (e.g., connection strings), use [User Secrets](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets) or environment variables as needed.

## Screenshots

### Home / Index Page
![Home Page](images/screenshot-home.png)

### CRUD Form
![CRUD Form](images/screenshot-form.png)

### Detail View
![Form Confirmation](images/screenshot-form_confirmation.png)

## Testing

Testing will be added in the future. (Stay tuned!)

## Contributing

Pull requests are welcome! Feel free to open an issue or submit a PR for improvements or bug fixes.

## Issues & Support

To report bugs, request features, or get support, please use the [GitHub Issues](https://github.com/tylerchasefranklin/ASP_NET_Core_MVC_Tutorial_App/issues) page.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---

For more information, visit the [project repository](https://github.com/tylerchasefranklin/ASP_NET_Core_MVC_Tutorial_App).