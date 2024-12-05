
using System.ComponentModel.DataAnnotations;
using TodoList.Domain.Primitives;

namespace TodoList.Domain.Entities;

public class TodoList : List<Todo>
{
    public TodoListId Id { get; private init; }
    public TodoListName Name { get; private set; }
    public DateTime CreateDate { get; private init; }
    public DateTime? UpdateDate { get; private set; }
    public bool CanBeDeleted => this.All(t => t.IsComplete);

    private TodoList(string name)
    {
        Id = new(Guid.CreateVersion7());
        Name = new(name);
        CreateDate = DateTime.Now;
    }

    public static TodoList Create
        ([Required(AllowEmptyStrings = false,
            ErrorMessage = Constants.ERROR_FOR_TODOLIST_NAME_REQUIRED),
         StringLength(maximumLength: Constants.MAX_LENGTH_FOR_TODOLIST_NAME,
            ErrorMessage = Constants.ERROR_FOR_TODOLIST_NAME_MAX_LENGTH,
            MinimumLength = Constants.MIN_LENGTH_FOR_TODOLIST_NAME),
         RegularExpression(@"[^\s+$]", ErrorMessage = Constants.ERROR_FOR_TODOLIST_NAME_REQUIRED)] string name) => new(name);

    /*public void Rename([Required, MaxLength(Constants.MAX_LENGTH_FOR_TODOLIST_NAME), MinLength(Constants.MIN_LENGTH_FOR_TODOLIST_NAME)] string name)
    {
        Name = new(name);
        UpdateDate = DateTime.Now;
    }
    public void DeleteTodo(Todo todo)
    {
        if (!todo.CanBeDeleted)
        {
            return;
        }
        else
        {
            Remove(todo);
        }
    }*/
}
