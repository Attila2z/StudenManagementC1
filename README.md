

# Student Management System - Database Schema Migrations

This repository contains the solution for the Student Management System assignment, demonstrating two database schema migration strategies:

Both approaches illustrate how to create an initial database schema and then apply a series of schema changes in an incremental, version-controlled manner.

## Project Overview

The Student Management System is designed to manage data for Students, Courses, and Enrollments (with additional entities added in later steps, such as Instructors and Departments). This project is implemented as a .NET console application using Entity Framework Core for the EF Code-First approach.

## Requirements

- .NET 6.0 (or later) / .NET Core
- SQL Server (LocalDB or Express)
- Entity Framework Core packages:
  - Microsoft.EntityFrameworkCore
  - Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.EntityFrameworkCore.Design
 ## Migration Approaches

### 1. EF Code-First (Change-Based) Approach

In the EF Code-First approach, every change to the data model is captured as an incremental migration using EF Core's tools. 

Subsequent Changes
For each schema change, update the models and then generate and apply a new migration:

V2__AddMiddleName: Add a MiddleName column to Student.
V3__AddDateOfBirth: Add a DateOfBirth column to Student.
V4__AddInstructor: Create an Instructor entity and add an InstructorId column to Course.
V5__RenameGrade: Rename Grade in Enrollment to FinalGrade.
V6__AddDepartment: Create a Department entity and set up a relationship with Instructor.
V7__ModifyCredits: Modify the data type of the Credits column in Course (e.g., from int to decimal(5,2)).
Each migration is versioned (V1, V2, …) and tracked in the Git history, making it easy to review incremental changes and collaborate with team members.

Advantages
Incremental History: Each change is captured as a distinct migration.
Automation: EF Core generates SQL based on your C# models.
Data Preservation: Most changes are non-destructive, keeping existing data intact.

State-Based Migration Approach
In the state-based approach, you create a series of SQL scripts that represent the final desired state of your schema after each set of changes. This method is often used when you need precise control over the SQL commands executed on the database.

Initial Schema (V1__InitialSchema.sql)

Advantages
Control: You write every SQL command, which gives you full control over how changes are applied.
Snapshot of Final State: Each script represents the final desired state of the database after the change.
Suitability for Some Environments: This approach can be useful in environments where incremental migrations are impractical.

