# 🍽️ SRP (SignalR Restaurant Project)

**SRP** is a comprehensive multi-layered web application developed with **.NET 8**, providing features such as menu management, real-time booking updates, order processing, live notifications, and API integrations. It leverages modern technologies like **SignalR**, **JWT Authentication**, **Entity Framework Core**, and more.

---

## 🚀 Features

- 🔐 **JWT Cookie Authentication** for secure login/logout
- 📡 **SignalR** for real-time updates (user count, reservations, statistics)
- 📊 Dynamic statistics and live dashboard
- 📩 Email sending functionality using `MailKit`
- 🖼️ QR code generation
- 🌍 Recipe fetching from **Tasty RapidAPI**
- 🧑‍💼 Admin panel with full CRUD operations
- 🧠 Clean layered architecture with **MediatR** and CQRS
- 🧹 Centralized error handling, logging, and caching mechanisms
- 🧪 Input validation using **FluentValidation**
- 📦 Configurable settings and environment support

---

## 🧱 Tech Stack

| Layer                | Technologies & Packages                                                                  |
|----------------------|------------------------------------------------------------------------------------------|
| **Backend**          | ASP.NET Core 8.0, EF Core 8, Identity, SignalR                                           |
| **Frontend**         | ASP.NET MVC, Razor Views, Bootstrap, jQuery                                              |
| **Security**         | JWT Authentication via `Microsoft.AspNetCore.Authentication.JwtBearer`                   |
| **Real-time**        | SignalR for client-server communication                                                  |
| **Validation**       | FluentValidation                                                                         |
| **Logging**          | Serilog (File + MSSQL sinks)                                                             |
| **Mailing**          | MailKit via `NETCore.MailKit`                                                            |
| **API Integration**  | Tasty RapidAPI                                                                           |
| **Object Mapping**   | AutoMapper                                                                               |

---

## 🏗️ Project Structure

- `SRP.WebUI` – Web MVC UI Layer (admin panel, views, real-time dashboard)
- `SRP.Application` – Business logic (CQRS, MediatR handlers, DTOs, validation rules)
- `SRP.Domain` – Entity models and domain contracts
- `SRP.Persistence` – EF Core implementation, repositories
- `Core.CrossCuttingConcerns` – Logging, caching, exception middleware
- `Core.Application`, `Core.Persistence` – Shared application infrastructure
---


[▶️ Watch Video on YouTube](https://www.youtube.com/watch?v=17nkJ7IUS6g)
