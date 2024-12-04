
using System.ComponentModel.DataAnnotations;
using TodoList.Domain.Primitives;

namespace TodoList.Domain.Entities;

public class Todo
{
    public TodoId Id { get; private init; }
    public TodoListId TodoListId { get; private init; }
    public TodoDescription Description { get; private init; }
    public DateOnly? DueDate { get; private init; }
    public bool IsImportant { get; private init; }
    public bool IsComplete { get; private init; }
    public DateTime CreateDate { get; private init; }
    public DateTime? UpdateDate { get; private init; }

    private Todo(TodoListId todoListId, string description, DateOnly? dueDate, bool isImportant, bool isComplete)
    {
        Id = new(Guid.CreateVersion7());
        TodoListId = todoListId;
        Description = new(description);
        DueDate = dueDate;
        IsImportant = isImportant;
        IsComplete = isComplete;
        CreateDate = DateTime.Now;
    }

    public bool IsIncludeInDueToday() => DueDate.HasValue && DueDate.Value == DateOnly.FromDateTime(DateTime.Today) && !IsComplete;
    public bool IsIncludeInImportant() => IsImportant && !IsComplete;
    public bool IsIncludeInCompleted() => IsComplete;

    public static Todo Create(TodoListId todoListId, [Required, MaxLength(Constants.MAX_LENGTH_FOR_TODO_DESC), MinLength(Constants.MIN_LENGTH_FOR_TODO_DESC)] string description, DateOnly? dueDate, bool isImportant, bool isComplete) => new(todoListId, description, dueDate, isImportant, isComplete);
    public bool IsValidForDelete() => !IsImportant;
}
