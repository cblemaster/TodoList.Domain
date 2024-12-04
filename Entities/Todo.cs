
using System.ComponentModel.DataAnnotations;
using TodoList.Domain.Primitives;

namespace TodoList.Domain.Entities;

public class Todo
{
    public TodoId TodoId { get; set; }
    public TodoListId TodoListId { get; set; }
    public TodoDescription Description { get; set; }
    public DateOnly? DueDate { get; set; }
    public bool IsImportant { get; set; }
    public bool IsComplete { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }

    private Todo(TodoListId todoListId, string description, DateOnly? dueDate, bool isImportant, bool isComplete)
    {
        TodoId = new(Guid.CreateVersion7());
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
