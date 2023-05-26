public class Book
{
    public string Author { get; set; }
    public string Title { get; set; }
    public int PageNumbers { get; set; }
    public DateTime PublishedDate { get; set; }
    public string Publisher { get; set; }
    public bool Hardback { get; set; }
    public int ISBN { get; set; }
    public bool IsBanned { get; set; }
    public bool Smugglable { get; set; }
    public Book(string AuthorName, string TitleParam)
    {
        Author = AuthorName;
        Title = TitleParam;
    }
}