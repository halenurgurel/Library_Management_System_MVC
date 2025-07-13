# 📚 Library Management System MVC – Documentation

## Project Purpose

This project is a web application built with ASP.NET Core MVC for managing book and author operations in a library. Users can add, edit, delete (soft delete), view details of books and authors, and restore deleted records.

---

## Setup and Running

1. **Download or Clone the Project:**
   - Download or clone all project files to your computer.
   - Add images (e.g., `library.png`) to the `wwwroot/images` folder.

2. **Open the Project:**
   - Open the `.sln` file in Visual Studio.
   - If necessary, right-click on the solution and select **Restore NuGet Packages**.

3. **Run the Project:**
   - Press the F5 key or click the "Start" button at the top.
   - The project will launch and the home page will open by default.

---

## Project Structure

- **Controllers/**  
  - `BookController.cs` – Book operations (list, details, add, edit, delete, deleted items)
  - `AuthorController.cs` – Author operations (list, details, add, edit, delete, deleted items)

- **Models/**  
  - `Book.cs` – Book model
  - `Author.cs` – Author model

- **Models/ViewModels/**  
  - `BookDetailViewModel.cs` – Transfers book and author info to the view
  - `AuthorDetailViewModel.cs` – Transfers author and book info to the view

- **Views/**  
  - `Book/` – Views for books (List, Details, Create, Edit, Delete, DeletedList)
  - `Author/` – Views for authors (List, Details, Create, Edit, Delete, DeletedList)
  - `Shared/_Layout.cshtml` – Common layout and navbar for all pages
  - `Shared/_FooterPartial.cshtml` – Footer partial

- **wwwroot/**  
  - Static files: images, css, js files

---

## Main Features

- **Book and Author Operations:**  
  - Add, list, view details, edit, delete (soft delete)
- **Deleted Items List:**  
  - Deleted books and authors are listed on a separate page and can be restored if desired
- **Home and About Pages:**  
  - Introduction and description of the project
- **Responsive Design:**  
  - Modern and mobile-friendly UI using Bootstrap
- **Partial View and Layout Usage:**  
  - Common footer and navbar with partial views

---

## How to Use

1. **Access the Books/Authors menu** to see the lists.
2. Use the "Add New" button to add new records.
3. You can view details, edit, or delete any item from the list.
4. View the "Deleted Items" menu to see deleted books or authors, and restore them if necessary.

---

## Configuration

- **Static Data Usage:**  
  - For educational purposes, data is kept in memory using lists. For real-life usage, a database should be used.
- **Soft Delete:**  
  - Deleted books or authors are not lost; they are flagged with the `IsDeleted` property.
- **Bootstrap:**  
  - For modern, responsive design.

---

## Testing

- After launching the application:
  - Try all add/edit/delete operations.
  - After deleting a record, check if it appears in the "Deleted Items" list and can be restored.
  - Add books and authors and verify their relationship is correctly shown.
  - Check the responsive design on mobile devices.

---

## Known Limitations

- Since data is stored **temporarily in memory (RAM)**, all records will be lost when the project is closed.
- For persistent data storage, integration with Entity Framework and a real database is recommended.

---

## Suggestions for Improvement

- Database integration (Entity Framework)
- User authentication (login/logout)
- Additional modules for library management (borrowing/returning books)
- Search and filtering features
- Exporting reports (PDF/Excel)

---

## Developer

- **Name:** (Add your name)
- **Date:** (Submission date)

---

> Feel free to contact me if you have any questions!
