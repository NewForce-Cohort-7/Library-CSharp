public class Library
{
    public string Address { get; set; }
    public int MaxNumberOfBooks { get; set; }
    private List<Book> LibraryInventory = new List<Book>();

    public void AddBook(Book singleBook)
    {
        if (LibraryInventory.Count < MaxNumberOfBooks)
        {
            LibraryInventory.Add(singleBook);
        }
        else
        {
            Console.WriteLine("Library is full");
        }
    }
}

//public data = property
//private data = field