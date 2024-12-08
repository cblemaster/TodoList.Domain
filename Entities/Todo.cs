
using TodoList.Domain.Primitives;

namespace TodoList.Domain.Entities;

internal record Todo(TodoId Id, TodoListId TodoListId, Descriptor Description, DateOnly? DueDate, bool IsImportant, bool IsComplete, DateTime CreateDate, DateTime? UpdateDate)
{
    internal bool IsIncludeInDueToday => DueDate.HasValue && DueDate.Value == DateOnly.FromDateTime(DateTime.Today) && !IsComplete;
    internal bool IsIncludeInOverdue => DueDate.HasValue && DueDate.Value < DateOnly.FromDateTime(DateTime.Today) && !IsComplete;
    internal bool IsIncludeInImportant => IsImportant && !IsComplete;
    internal bool IsIncludeInCompleted => IsComplete;
    internal bool CanBeUpdated => !IsComplete;
    internal bool CanBeDeleted => !IsImportant;
}
