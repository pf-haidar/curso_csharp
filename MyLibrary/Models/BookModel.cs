namespace MyLibrary.Models;

public class BookModel
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public MoviesGenres Genres { get; set; }
    public double Price { get; set; }
    public int QuantityAvailable { get; set; }
}
