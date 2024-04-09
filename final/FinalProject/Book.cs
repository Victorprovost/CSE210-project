class Book : LibraryItem
{
    public string ISBN { get; set; }

    public Book(string title, string author, int publicationYear, string isbn) : base(title, author, publicationYear)
    {
        ISBN = isbn;
    }

    public override void CheckOut()
    {
        if (Available)
        {
            Available = false;
            Console.WriteLine($"Book '{Title}' checked out successfully.");
        }
        else
        {
            Console.WriteLine($"Book '{Title}' is not available.");
        }
    }

    public override void ReturnItem()
    {
        Available = true;
        Console.WriteLine($"Book '{Title}' returned successfully.");
    }
}