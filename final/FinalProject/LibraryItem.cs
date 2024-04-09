abstract class LibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }
    public bool Available { get; set; }

    public LibraryItem(string title, string author, int publicationYear)
    {
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
        Available = true;
    }

    public abstract void CheckOut();
    public abstract void ReturnItem();
}