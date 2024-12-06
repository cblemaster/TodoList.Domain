
namespace TodoList.Domain.Aggregates;

public readonly record struct SeeTodoListSummaries(Guid TodoListId, string ListName, int CountOfTodosNotComplete);
