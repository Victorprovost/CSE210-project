class LibraryMember
{
    private string Name { get; set; }
    private string MemberID { get; set; }
    public List<LibraryItem> BorrowedItems { get; set; }

    public LibraryMember(string name, string memberID)
    {
        Name = name;
        MemberID = memberID;
        BorrowedItems = new List<LibraryItem>();
    }

    public void CheckOutItem(LibraryItem item)
    {
        item.CheckOut();
        BorrowedItems.Add(item);
    }

    public void ReturnItem(LibraryItem item)
    {
        item.ReturnItem();
        BorrowedItems.Remove(item);
    }
}