namespace LibraryApp.Models;

/// <summary>
/// Represents a book in the library
/// </summary>
public class Book
{
    public string Id { get; set; } // unique id (GUID string)
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; } = true;
    public string? BorrowedByMemberId { get; set; } = null;

    public Book()
    {
        Id = Guid.NewGuid().ToString();
        Title = string.Empty;
        Author = string.Empty;
        IsAvailable = true;
    }

    public Book(string title, string author)
    {
        this.Id = Guid.NewGuid().ToString();
        this.Title = title;
        this.Author = author;
        this.IsAvailable = true;
    }

    public override string ToString() => $"{Title} — {Author} (Id: {Id}) {(IsAvailable ? "[Available]" : "[Borrowed]")}";
}

