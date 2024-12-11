using TodoList.Domain.Primitives;
using TodoList.Domain.ValueStructs;

namespace TodoList.Domain.Entities;

internal record Todo(TodoId Id, TodoListId ListId, TodoList List, Descriptor Description, DateOnly? DueDate, bool IsImportant, bool IsComplete, DateTimeStamps Dates)
{
    internal bool CanBeUpdated => !IsComplete;
    internal bool CanBeDeleted => !IsImportant;
}
