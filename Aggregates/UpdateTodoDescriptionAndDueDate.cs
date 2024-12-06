
namespace TodoList.Domain.Aggregates;

public readonly record struct UpdateTodoDescriptionAndDueDate(Guid TodoId, string Description, DateTime? DueDate);
