﻿
using System.ComponentModel.DataAnnotations;
using TodoList.Domain.Primitives;

namespace TodoList.Domain.Entities;

public class Todo
{
    public TodoId Id { get; private init; }
    public TodoListId TodoListId { get; private init; }
    public TodoDescription Description { get; private set; }
    public DateOnly? DueDate { get; private set; }
    public bool IsImportant { get; private set; }
    public bool IsComplete { get; private set; }
    public DateTime CreateDate { get; private init; }
    public DateTime? UpdateDate { get; private set; }
    public bool IsIncludeInDueToday => DueDate.HasValue && DueDate.Value == DateOnly.FromDateTime(DateTime.Today) && !IsComplete;
    public bool IsIncludeInOverdue => DueDate.HasValue && DueDate.Value < DateOnly.FromDateTime(DateTime.Today) && !IsComplete;
    public bool IsIncludeInImportant => IsImportant && !IsComplete;
    public bool IsIncludeInCompleted => IsComplete;
    public bool CanBeUpdated => !IsComplete;
    public bool CanBeDeleted => !IsImportant;

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

    public static Todo Construct
        (TodoListId todoListId,

        [Required(AllowEmptyStrings = false,
            ErrorMessage = Constants.ERROR_FOR_TODO_DESC_REQUIRED),
        StringLength(maximumLength: Constants.MAX_LENGTH_FOR_TODO_DESC,
            ErrorMessage = Constants.ERROR_FOR_TODO_DESC_MAX_LENGTH,
            MinimumLength = Constants.MIN_LENGTH_FOR_TODO_DESC),
        RegularExpression(@"[^\s+$]", ErrorMessage = Constants.ERROR_FOR_TODO_DESC_REQUIRED)]
        string description,

        DateOnly? dueDate,
        bool isImportant,
        bool isComplete) => new(todoListId, description, dueDate, isImportant, isComplete);
}
