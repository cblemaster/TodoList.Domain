
namespace TodoList.Domain;

internal record Todo(TodoId Id, TodoListId ListId, TodoList List, Descriptor Description, DateOnly? DueDate, bool IsImportant, bool IsComplete, DateTimeStamps Dates);
