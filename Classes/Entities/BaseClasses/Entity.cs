
using TodoList.Domain.Classes.Primitives;

namespace TodoList.Domain.Classes.Entities.BaseClasses;

internal abstract class Entity<T>
{
    internal required abstract Id<T> Id { get; init; }
}
