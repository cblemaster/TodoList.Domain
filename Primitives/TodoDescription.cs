
using System.ComponentModel.DataAnnotations;

namespace TodoList.Domain.Primitives;

public class TodoDescription([Required, MaxLength(Constants.MAX_LENGTH_FOR_TODO_DESC), MinLength(Constants.MIN_LENGTH_FOR_TODO_DESC)] string value)
{
    public string Value { get; set; } = value;
}
