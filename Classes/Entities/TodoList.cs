using TodoList.Domain.Classes.BaseClasses;
using TodoList.Domain.Classes.Primitives;

namespace TodoList.Domain.Classes.Entities;

internal class TodoList : Entity<TodoList>
{
    internal Id<TodoList> _id;

    internal IEnumerable<Todo> Todos { get; init; } = [];
    internal required override Id<TodoList> Id { get => _id; init => _id = value; }
    internal required string ListName { get; init; }
    internal required Dates Dates { get; init; }
}
