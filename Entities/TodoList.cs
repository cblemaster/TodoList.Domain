
using TodoList.Domain.Primitives;

namespace TodoList.Domain.Entities;

internal class TodoList : List<Todo>
{
    internal required TodoListId Id { get; init; }
    internal required Descriptor Name { get; init; }
    internal required DateTime CreateDate { get; init; }
    internal required DateTime? UpdateDate { get; init; }
    internal bool CanBeDeleted => this.All(t => t.IsComplete);

    private TodoList() { }

    public TodoList Construct(Descriptor name) => new()
    {
        Id = new TodoListId(),
        Name = name,
        CreateDate = DateTime.Now,
        UpdateDate = null
    };
}
