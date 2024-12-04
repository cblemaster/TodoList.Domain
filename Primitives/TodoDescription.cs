
using System.ComponentModel.DataAnnotations;

namespace TodoList.Domain.Primitives;

public readonly record struct TodoDescription([Required, MaxLength(Constants.MAX_LENGTH_FOR_TODO_DESC), MinLength(Constants.MIN_LENGTH_FOR_TODO_DESC)] string Value);
