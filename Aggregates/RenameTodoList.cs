
namespace TodoList.Domain.Aggregates;

public readonly record struct RenameTodoList(Guid TodoListId, string Name);
