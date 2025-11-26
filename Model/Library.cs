using System;
using System.Collections.Generic;

public class Library
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    // ----------------------------------------------------
    // Add a new book (ID must be unique)
    // ----------------------------------------------------
    public void AddBook(Book book)
    {
        if (book == null)
            throw new ArgumentNullException(nameof(book), "Book cannot be null.");

        // Validation: ID must be unique
        if (books.Any(b => b.Id == book.Id))
        {
            throw new ArgumentException("A book with the same ID already exists.");
        }

        books.Add(book);
    }

    // ----------------------------------------------------
    // Get all books
    // ----------------------------------------------------
    public List<Book> GetAllBooks()
    {
        return books;
    }

    // ----------------------------------------------------
    // Search by title
    // ----------------------------------------------------
    public List<Book> SearchByTitle(string title)
    {
        return books
            .Where(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    // ----------------------------------------------------
    // Search by author
    // ----------------------------------------------------
    public List<Book> SearchByAuthor(string author)
    {
        return books
            .Where(b => b.Author.Contains(author, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    // ----------------------------------------------------
    // Borrow a book using ID
    // ----------------------------------------------------
    public bool BorrowBook(int id)
    {
        var book = books.FirstOrDefault(b => b.Id == id);

        if (book == null)
            return false;

        if (book.IsBorrowed)
            return false;

        book.IsBorrowed = true;
        return true;
    }

    // ----------------------------------------------------
    // Return a book using ID
    // ----------------------------------------------------
    public bool ReturnBook(int id)
    {
        var book = books.FirstOrDefault(b => b.Id == id);

        if (book == null)
            return false;

        if (!book.IsBorrowed)
            return false;

        book.IsBorrowed = false;
        return true;
    }

    // ----------------------------------------------------
    // Remove a book using ID
    // ----------------------------------------------------
    public bool RemoveBook(int id)
    {
        var book = books.FirstOrDefault(b => b.Id == id);

        if (book == null)
            return false;

        return books.Remove(book);
    }
}
}
