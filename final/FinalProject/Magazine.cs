class Magazine : LibraryItem
{
    public int IssueNumber { get; set; }

    public Magazine(string title, string author, int publicationYear, int issueNumber) : base(title, author, publicationYear)
    {
        IssueNumber = issueNumber;
    }

    public override void CheckOut()
    {
        if (Available)
        {
            Available = false;
            Console.WriteLine($"Magazine '{Title}' checked out successfully.");
        }
        else
        {
            Console.WriteLine($"Magazine '{Title}' is not available.");
        }
    }

    public override void ReturnItem()
    {
        Available = true;
        Console.WriteLine($"Magazine '{Title}' returned successfully.");
    }
}