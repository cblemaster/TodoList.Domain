
namespace TodoList.Domain.Aggregates;

public readonly record struct ListSummary(Guid ListId, string Name, int CountOfTodosNotComplete, DateTime CreateDate, DateTime? UpdateDate);
