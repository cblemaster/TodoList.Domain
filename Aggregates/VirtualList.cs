
namespace TodoList.Domain.Aggregates;

public readonly record struct VirtualList(Guid TodoListId, string Name, IEnumerable<SeeTodoSummaries> Todos);
