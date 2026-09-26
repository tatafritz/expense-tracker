# Expense Tracker

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Learning Project](https://img.shields.io/badge/Learning%20Project-FFD700?style=for-the-badge)

I was having some trouble keeping track of my expenses and income recently, so I thought, "Why not build something to fix it?"

I could have simply used Excel or a pre-made application, but I thought this would be a great opportunity to:

1. Practice C# and OOP concepts.
2. Build something as a CLI application, since I really enjoy using the terminal in my daily workflow.

The project isn't complete yet, but here are some of the features I've implemented so far, along with some of the improvements I have planned:

## Features

* Add expenses
* List all expenses
* Update expenses
* Delete expenses
* Automatically generate expense IDs
* Keep expense IDs sequential after deletion
* Display expenses in a formatted CLI table

## Technologies

* C#
* .NET
* Console Application

## Project Structure

```text
ExpenseTracker/
│
├── Models/
│   └── Expense.cs
│
├── Services/
│   └── ExpenseService.cs
│
└── Program.cs
```

### Models

Contains the classes that represent the application's data.

### Services

Contains the logic for managing expenses, including adding, retrieving, updating, and deleting expenses.

### Program.cs

Handles the CLI interface and user interaction.

## How to Run

### Prerequisites

* [.NET SDK](https://dotnet.microsoft.com/download)

### Clone the repository

```bash
git clone https://github.com/tatafritz/expense-tracker
```

Navigate to the project directory:

```bash
cd expense-tracker
```

Run the application:

```bash
dotnet run
```

## Usage

When the application starts, you will see the main menu:

```text
==== Expense Tracker ====

[1] - Add an expense
[2] - List all expenses
[3] - Update an expense
[4] - Delete an expense
[0] - Exit
```

Follow the options displayed in the terminal to manage your expenses.

## Learning Goals

This project is part of my journey to improve my C# skills through practical projects.

Some of the concepts practiced in this project include:

* Classes and objects
* Properties
* Lists and collections
* Reference types
* LINQ
* CRUD operations
* Service classes
* Basic separation of responsibilities
* String formatting
* Date and currency formatting

## Current Limitations

Expenses are currently stored only in memory.

This means that all expenses are lost when the application is closed.

Future versions may introduce persistent storage and additional expense-management features.

## Next Improvements

Some features I may explore in future versions:

* [ x ] Input validation
* [ ] Persistent storage with JSON
* [ ] Expense categories
* [ ] Search and filtering
* [ ] Expense summaries
* [ ] Budget tracking
* [ ] Income tracking
* [ ] CSV import/export
* [ ] Persistent storage with a database (?)