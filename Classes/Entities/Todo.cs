using TodoList.Domain.Classes.BaseClasses;
using TodoList.Domain.Classes.Primitives;

namespace TodoList.Domain.Classes.Entities;

internal class Todo : Entity<Todo>
{
    private Id<Todo> _id;

    internal override required Id<Todo> Id { get => _id; init => _id = value; }
    internal required string Description { get; init; }
    internal DateOnly? DueDate { get; init; }
    internal bool IsImportant { get; init; }
    internal bool IsComplete { get; init; }
    internal required Dates Dates { get; init; }
}
