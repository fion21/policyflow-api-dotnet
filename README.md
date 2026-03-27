PolicyFlow API  
==============

A C# ASP.NET Core Web API designed to simulate a real-world insurance policy workflow system.

This project goes beyond basic CRUD by modelling workflow-driven processing, validation, audit tracking, and operational metrics. It reflects how backend systems support high-volume environments where data accuracy, traceability, and efficiency are critical.
 
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


```git clone https://github.com/YOUR-USERNAME/PolicyFlowApi.git```

cd PolicyFlowApi


Install dependencies


```dotnet restore```


Run the application


```dotnet run```


Open Swagger in your browser


http://localhost:5244/swagger


If a different port appears in the terminal, use that instead.

---

Example Usage  
-------------

Create a policy


{
"policyNumber": "POL-3001",
"customerName": "Amina Patel",
"policyType": "Health Standard",
"premium": 275
}


Update policy status


{
"newStatus": "Submitted",
"changedBy": "Fiona"
}


---

Available Endpoints  
-------------------

- GET /api/Policies  
- GET /api/Policies/{id}  
- POST /api/Policies  
- PUT /api/Policies/{id}/status  
- GET /api/Metrics  
- GET /api/policies/{policyId}/history  

---

Notes  
-----

- The application uses an in-memory database so data resets on restart  
- Swagger is used to test all endpoints  
- No external database setup is required  

---

Why this project  
----------------

This project was built to reflect the type of backend systems used in workflow-heavy environments such as insurance and operations platforms.

It focuses on more than just data storage by incorporating:

- controlled state transitions  
- audit history tracking  
- validation and error handling  
- performance metrics  

These are key elements of production-grade backend systems.

---

Author  
------

Fiona L
Software Developer focused on backend systems, workflow design, and scalable application architecture.
