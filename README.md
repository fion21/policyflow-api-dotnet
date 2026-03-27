PolicyFlow API  
==============

A C# ASP.NET Core Web API designed to simulate a real-world insurance policy workflow system.

This project goes beyond basic CRUD by modelling workflow-driven processing, validation, audit tracking, and operational metrics. It reflects how backend systems support high-volume environments where data accuracy, traceability, and efficiency are critical.

---

What this demonstrates  
----------------------

- Designing APIs around real business workflows  
- Implementing validation and enforcing business rules  
- Managing state transitions in a controlled process  
- Tracking audit history for compliance and traceability  
- Measuring system performance through metrics  
- Structuring a maintainable backend using clean architecture principles  

---

Key Features  
------------

- Create and retrieve policies  
- Workflow-based status updates (Draft, Submitted, Processed, etc.)  
- Enforcement of valid status transitions  
- Duplicate policy number protection  
- Timestamp tracking for workflow stages  
- Full audit history of status changes  
- Metrics endpoint for operational insight  
- Input validation using Data Annotations  

---

Architecture  
------------

The application follows a layered and maintainable structure:

- Controllers manage HTTP requests and responses  
- DTOs handle input validation and data transfer  
- Services contain business logic and workflow rules  
- Entity Framework Core InMemory simulates persistence  
- Dependency Injection is used throughout  

---

Tech Stack  
----------

- C#  
- ASP.NET Core Web API  
- Entity Framework Core InMemory  
- Swagger OpenAPI  

---

Getting Started  
---------------

Follow these steps to run the project locally.

Clone the repository
