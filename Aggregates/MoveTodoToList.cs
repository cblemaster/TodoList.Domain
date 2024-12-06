
namespace TodoList.Domain.Aggregates;

public readonly record struct MoveTodoToList(Guid TodoId, Guid TodoListId);
