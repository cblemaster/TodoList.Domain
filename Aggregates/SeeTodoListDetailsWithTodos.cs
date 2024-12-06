
namespace TodoList.Domain.Aggregates;

public readonly record struct SeeTodoListDetailsWithTodos(Guid TodoListId, string ListName, IEnumerable<SeeTodoSummaries> Todos, DateTime CreateDate, DateTime? UpdateDate);
