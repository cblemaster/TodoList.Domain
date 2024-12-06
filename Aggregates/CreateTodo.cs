
namespace TodoList.Domain.Aggregates;

public readonly record struct CreateTodo(Guid TodoId, Guid TodoListId, string Description, DateTime? DueDate, bool IsImportant, bool IsComplete);
