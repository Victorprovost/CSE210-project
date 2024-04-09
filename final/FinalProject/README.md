# Library Management System

## Overview
This project is a simple implementation of a Library Management System in C#. It provides classes for managing library items (books, magazines, DVDs), library members, and the library catalog.

## Features
- **LibraryItem**: Abstract class representing a generic library item with common attributes like title, author, publication year, and availability status.
- **Book, Magazine, DVD**: Subclasses of LibraryItem representing specific types of library items, each with additional attributes and methods for actions like checking out and returning items.
- **LibraryMember**: Class representing a library member with attributes like name, member ID, and a list of borrowed items, with methods for checking out and returning items.
- **LibraryCatalog**: Class managing the collection of library items and members, providing methods for adding, removing, and searching items, as well as managing member accounts.

## Usage
1. Clone or download the project to your local machine.
2. Open the project in your preferred C# IDE or text editor.
3. Run the `Program.cs` file to execute the sample usage of the Library Management System.
4. Explore and modify the code as needed for your specific requirements.

## Classes
### LibraryItem
- **Properties**: Title, Author, PublicationYear, Available
- **Abstract Methods**: CheckOut(), ReturnItem()

### Book
- **Additional Properties**: ISBN
- **Overrides**: CheckOut(), ReturnItem()

### Magazine
- **Additional Properties**: IssueNumber
- **Overrides**: CheckOut(), ReturnItem()

### DVD
- **Additional Properties**: Duration
- **Overrides**: CheckOut(), ReturnItem()

### LibraryMember
- **Properties**: Name, MemberID, BorrowedItems
- **Methods**: CheckOutItem(), ReturnItem()

### LibraryCatalog
- **Properties**: LibraryItems, Members
- **Methods**: AddItem(), RemoveItem(), AddMember(), RemoveMember(), SearchItem()

## Example
```csharp
LibraryCatalog catalog = new LibraryCatalog();

Book book1 = new Book("Python Programming", "John Smith", 2020, "978-0-13-444432-1");
Magazine magazine1 = new Magazine("National Geographic", "Various", 2023, 4);
DVD dvd1 = new DVD("The Matrix", "Lana Wachowski", 1999, 136);

catalog.AddItem(book1);
catalog.AddItem(magazine1);
catalog.AddItem(dvd1);

LibraryMember member1 = new LibraryMember("Alice", "001");
catalog.AddMember(member1);

List<LibraryItem> searchResults = catalog.SearchItem("Python");

member1.CheckOutItem(book1);
member1.ReturnItem(book1);

catalog.RemoveMember(member1);
