
using System.ComponentModel.DataAnnotations;

namespace TodoList.Domain.Primitives;

public class TodoListName([Required, MaxLength(Constants.MAX_LENGTH_FOR_TODOLIST_NAME), MinLength(Constants.MIN_LENGTH_FOR_TODOLIST_NAME)] string value)
{
    public string Value { get; set; } = value;
}
