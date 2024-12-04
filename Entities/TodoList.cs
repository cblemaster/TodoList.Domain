
using System.ComponentModel.DataAnnotations;
using TodoList.Domain.Primitives;

namespace TodoList.Domain.Entities;

public class TodoList : List<Todo>
{
    private const int MAX_LENGTH_FOR_NAME = 255;
    private const int MIN_LENGTH_FOR_NAME = 1;

    public TodoListId Id { get; private init; }
    public TodoListName Name { get; private set; }
    public DateTime CreateDate { get; private init; }
    public DateTime? UpdateDate { get; private set; }

    private TodoList(string name)
    {
        Id = new(Guid.CreateVersion7());
        Name = new(name);
        CreateDate = DateTime.Now;
    }

    public static TodoList Create([Required, MaxLength(MAX_LENGTH_FOR_NAME), MinLength(MIN_LENGTH_FOR_NAME)] string name) => new(name);
    public void Rename([Required, MaxLength(MAX_LENGTH_FOR_NAME), MinLength(MIN_LENGTH_FOR_NAME)] string name)
    {
        Name = new(name);
        UpdateDate = DateTime.Now;
    }
    public bool IsValidForDelete() => this.All(t => t.IsComplete);
}
