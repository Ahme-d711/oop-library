using System;

public class LibraryService
{
    private Library library;

    public LibraryService()
    {
        library = new Library();
    }

    // ----------------------------------------------------
    // Add a new book
    // ----------------------------------------------------
    public string AddBook(int id, string title, string author)
    {
        if (string.IsNullOrWhiteSpace(title))
            return "Title cannot be empty.";

        if (string.IsNullOrWhiteSpace(author))
            return "Author cannot be empty.";

        Book newBook = new Book
        {
            Id = id,
            Title = title,
            Author = author,
            IsBorrowed = false
        };

        try
        {
            library.AddBook(newBook);
            return "Book added successfully.";
        }
        catch (Exception ex)
        {
            return "Error: " + ex.Message;
        }
    }

    // ----------------------------------------------------
    // Get all books
    // ----------------------------------------------------
    public List<Book> GetAllBooks()
    {
        return library.GetAllBooks();
    }

    // ----------------------------------------------------
    // Search by title
    // ----------------------------------------------------
    public List<Book> FindBooksByTitle(string title)
    {
        return library.SearchByTitle(title);
    }

    // ----------------------------------------------------
    // Search by author
    // ----------------------------------------------------
    public List<Book> FindBooksByAuthor(string author)
    {
        return library.SearchByAuthor(author);
    }

    // ----------------------------------------------------
    // Borrow a book by ID
    // ----------------------------------------------------
    public string BorrowBook(int id)
    {
        bool result = library.BorrowBook(id);

        if (result)
            return "Book borrowed successfully.";
        else
            return "Book cannot be borrowed (not found or already borrowed).";
    }

    // ----------------------------------------------------
    // Return a book by ID
    // ----------------------------------------------------
    public string ReturnBook(int id)
    {
        bool result = library.ReturnBook(id);

        if (result)
            return "Book returned successfully.";
        else
            return "Book cannot be returned (not found or was not borrowed).";
    }

    // ----------------------------------------------------
    // Remove book
    // ----------------------------------------------------
    public string RemoveBook(int id)
    {
        bool result = library.RemoveBook(id);

        if (result)
            return "Book removed successfully.";
        else
            return "Book not found.";
    }
}
}