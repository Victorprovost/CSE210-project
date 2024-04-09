class LibraryCatalog
{
    public List<LibraryItem> LibraryItems { get; set; }
    public List<LibraryMember> Members { get; set; }

    public LibraryCatalog()
    {
        LibraryItems = new List<LibraryItem>();
        Members = new List<LibraryMember>();
    }

    public void AddItem(LibraryItem item)
    {
        LibraryItems.Add(item);
    }

    public void RemoveItem(LibraryItem item)
    {
        if (LibraryItems.Contains(item))
        {
            LibraryItems.Remove(item);
            Console.WriteLine($"Item '{item.Title}' removed from catalog.");
        }
        else
        {
            Console.WriteLine("Item not found in catalog.");
        }
    }

    public void AddMember(LibraryMember member)
    {
        Members.Add(member);
    }

    public void RemoveMember(LibraryMember member)
    {
        if (Members.Contains(member))
        {
            Members.Remove(member);
            Console.WriteLine($"Member '{member.Name}' removed from library.");
        }
        else
        {
            Console.WriteLine("Member not found in library.");
        }
    }

    public List<LibraryItem> SearchItem(string title)
    {
        return LibraryItems.FindAll(item => item.Title.ToLower().Contains(title.ToLower()));
    }
}