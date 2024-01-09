# Boilerplate: ASP.NET Core Web API application

A multifunctional enterprise HTTP API project template based on modern approaches and the latest version of .NET 8.

*Change `BoilerplateApi` to your project name.*

## Features Summary:

- ORM and Migrations by Entity Framework 8.0
- Authentication and authorization by ASP.NET Core Identity
- Logger by [Serilog](https://serilog.net/)
- Swagger by [Swashbuckle](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)
- Tests by [xUnit](https://xunit.net/)
- Metrics for Prometheus by [prometheus-net](https://github.com/prometheus-net/prometheus-net)
- Docker

## .NET 8

The new .NET 8 version was released just a few weeks ago.
And the [Valletta Software](https://www.vallettasoftware.com/) team is already ready to develop and implement solutions for your business based on this modern stack.

## Entity Framework and Migrations

We use Entity Framework ORM as persistance layer, and the database structure is hold under control by Migrations.
Such approach allows us speed up and automate whole development process as much as possible.
You can make it as a part of any CI/CD process with no effort.
On the other hand, the database is safe. Keep in mind, it is the most important business part of the enterprise application.

## Authentication and authorization

An enterprise solutions require restricting access to specific functions through authentication and authorization.
There is ASP.NET Core Identity available out of the box. There are accounts, roles, and sessions.

## Logger

The logger is already provided. Use it both as the JSON records and the pure console text.

## Swagger 

Swagger provides Web UI to explore and test the endpoints of the HTTP API.
It includes Authentication, as well.

## Tests

xUnit library is used for tests.
Tests are in a separate project, as they should not be shipped with the application.

## Metrics

Runtime application monitoring is a must-have tool for service control.
To service high loads, it is important to ensure horizontal and/or vertical scaling of the application.
The project already provides standard system metrics for Prometheus.
You are also free to add any business-specific metrics.

## Docker

Any modern application should support running in a container.
There is a Dockerfile ready to use.
