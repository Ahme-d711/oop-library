namespace LibraryApp.Models;

/// <summary>
/// Sealed class - cannot be inherited (Final class equivalent)
/// </summary>
public sealed class Utility
{
    public static string LibraryName { get; set; } = "Library Management System";
    
    public static string GetLibraryInfo()
    {
        return $"Welcome to {LibraryName}";
    }

    private Utility() { }
}

