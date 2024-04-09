class system;

class Program
{
    static void Main(string[] args)
    {
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
    }
}