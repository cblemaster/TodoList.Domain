﻿
namespace TodoList.Domain.DataTransfer;

public class TodoSummary
{
    public string Description { get; set; } = string.Empty;
    public DateOnly? DueDate { get; set; }
    public bool IsImportant { get; set; }
    public bool IsComplete { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public Guid TodoId { get; set; }
    public Guid TodoListId { get; set; }
}
