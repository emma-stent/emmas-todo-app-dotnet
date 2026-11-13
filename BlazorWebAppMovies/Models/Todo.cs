namespace BlazorWebAppMovies.Models;

public class Todo
{
    public string Title { get; set; } = "";
    public Guid Id { get; set; } = Guid.NewGuid();
    public bool IsCompleted { get; set; }
}