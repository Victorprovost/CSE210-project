class DVD : LibraryItem
{
    public int Duration { get; set; }

    public DVD(string title, string author, int publicationYear, int duration) : base(title, author, publicationYear)
    {
        Duration = duration;
    }

    public override void CheckOut()
    {
        if (Available)
        {
            Available = false;
            Console.WriteLine($"DVD '{Title}' checked out successfully.");
        }
        else
        {
            Console.WriteLine($"DVD '{Title}' is not available.");
        }
    }

    public override void ReturnItem()
    {
        Available = true;
        Console.WriteLine($"DVD '{Title}' returned successfully.");
    }
}