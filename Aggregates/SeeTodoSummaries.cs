
namespace TodoList.Domain.Aggregates;

public readonly record struct SeeTodoSummaries(Guid TodoId, Guid TodoListId, string Description, DateTime? DueDate, bool IsImportant, bool IsComplete, DateTime CreateDate, DateTime? UpdateDate);
