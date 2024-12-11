using TodoList.Domain.Primitives;
using TodoList.Domain.ValueStructs;

namespace TodoList.Domain.Entities;

internal record TodoList(TodoListId Id, Descriptor Name, ICollection<Todo> Todos, DateTimeStamps Dates)
{
    internal bool CanBeDeleted = Todos.All(t => t.IsComplete);
}
