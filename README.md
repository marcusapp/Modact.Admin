# ✨ Modact — Modular & Action API Framework

**Modact** is a modern, modular, and expressive RPC-style API framework built atop **C#** and **.NET 8**, empowering developers to create seamless remote procedure calls using simple `POST`-based WebAPI endpoints.

## 🚀 Overview

Modact abstracts the complexity of traditional RESTful APIs by enabling developers to define **action-based endpoints** that are called dynamically via method names and parameters. No more routing clutter or controller sprawl — just clean, direct invocation of logic through intuitive RPC semantics. All the called function in one request could be committed together when success and rollback when error occurred. That call each request is as an ACTION.

---

## 🌟 Key Features

- **🧬 Modular Action Dispatching**  
  Dynamically maps .DLL module with method names to target logic using reflection or attribute-based registration.

- **📡 RPC over HTTP POST**  
  Simplifies frontend-backend communication by encapsulating RPC calls into elegant `POST` payloads.

- **🛠 Built with Modern C# & .NET 8**  
  Harness the latest performance, trimming, and AOT improvements.

- **⚙️ Extensible Middleware Pipeline**  
  Integrates seamlessly with ASP.NET Core middlewares (auth, logging, validation).

- **🔐 Built-in Support for Security**  
  JWT authentication, per-method authorization, and request validation baked in.

- **📈 Observable by Design**  
  Structured logs and error traces designed for distributed observability.

- **🌍 Cloud-Ready Deployment**  
  Perfectly aligned for containerization (Docker), orchestration (Kubernetes), or serverless scenarios.

---

![Image](https://github.com/user-attachments/assets/c8395920-a3b1-42ea-8058-2427aa6cedee)

![Image](https://github.com/user-attachments/assets/e6de1655-a44b-4f73-a4e3-e7bd2a2c752e)

![Image](https://github.com/user-attachments/assets/74cdded2-f960-4105-ad3d-4916ef3cfa5c)
