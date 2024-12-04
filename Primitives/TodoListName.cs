
using System.ComponentModel.DataAnnotations;

namespace TodoList.Domain.Primitives;

public readonly record struct TodoListName([Required, MaxLength(Constants.MAX_LENGTH_FOR_TODOLIST_NAME), MinLength(Constants.MIN_LENGTH_FOR_TODOLIST_NAME)] string Value);
