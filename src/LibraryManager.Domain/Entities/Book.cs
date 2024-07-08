namespace LibraryManager.Domain.Entities;

public class Book
{
    public long Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public IEnumerable<Genre> Genre { get; set; } = [];
    public decimal Pricing { get; set; }
    public int AmountInStock { get; set; }
}