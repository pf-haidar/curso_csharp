using MyLibrary.Models;

namespace MyLibrary.Communication;

public class RequestRegisterBookJson
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public MoviesGenres Genres { get; set; }
    public float Price { get; set; }
    public int QuantityAvailable { get; set; }
}
