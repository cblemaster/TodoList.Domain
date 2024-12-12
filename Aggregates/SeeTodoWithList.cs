
using TodoList.Domain.Primitives;
using TodoList.Domain.ValueStructs;

namespace TodoList.Domain.Aggregates;

internal record SeeTodoWithList(TodoId Id, TodoListId ListId, Entities.TodoList List, Descriptor Description, DateOnly? DueDate, bool IsImportant, bool IsComplete, DateTimeStamps Dates);
