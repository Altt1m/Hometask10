class Book
{
    // Properties or Fields
    private string Title { get; set; }
    private string Author { get; set; }
    private int bookmark;

    // Methods
    public void Open()
    {
        Console.WriteLine("Book opened.");
    }

    public void Close()
    {
        Console.WriteLine("Book closed.");
    }

    public void Bookmark(int page)
    {
        Console.WriteLine("Bookmark set on {0}. page.", page);
    }
}