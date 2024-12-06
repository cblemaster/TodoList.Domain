
namespace TodoList.Domain.Aggregates;

public readonly record struct CreateTodoList(Guid TodoListId, string Name);
