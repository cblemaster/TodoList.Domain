
using System.ComponentModel.DataAnnotations;

namespace TodoList.Domain;

public class TodoList : List<Todo>
{
    private const int MAX_LENGTH_FOR_NAME = 255;
    private const int MIN_LENGTH_FOR_NAME = 1;

    public Guid TodoListId { get; set; }
    public string Name { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }

    private TodoList(string name)
    {
        TodoListId = Guid.NewGuid();
        Name = name;
        CreateDate = DateTime.Now;
    }
    
    public static TodoList Create([Required, MaxLength(MAX_LENGTH_FOR_NAME), MinLength(MIN_LENGTH_FOR_NAME)] string name) => new(name);
    public void Rename([Required, MaxLength(MAX_LENGTH_FOR_NAME)] string name)
    {
        Name = name;
        UpdateDate = DateTime.Now;
    }
    public bool IsValidForDelete() => this.All(t => t.IsComplete);
}
