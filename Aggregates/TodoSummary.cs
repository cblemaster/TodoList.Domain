
namespace TodoList.Domain.Aggregates;

public readonly record struct TodoSummary(Guid TodoId, Guid ListId, string Description, DateOnly? DueDate, bool IsImportant, bool IsComplete, DateTime CreateDate, DateTime? UpdateDate);
