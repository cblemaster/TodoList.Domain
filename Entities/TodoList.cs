
using TodoList.Domain.Primitives;

namespace TodoList.Domain.Entities;

internal class TodoList : List<Todo>
{
    internal required TodoListId Id { get; init; }
    internal required Descriptor Name { get; init; }
    internal required DateTime CreateDate { get; init; }
    internal required DateTime? UpdateDate { get; init; }
    internal bool CanBeDeleted => this.All(t => t.IsComplete);

    internal TodoList(Descriptor name)
    {
        Id = new(Guid.CreateVersion7());
        Name = name;
        CreateDate = DateTime.Now;
    }
}
