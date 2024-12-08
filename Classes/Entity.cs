
namespace TodoList.Domain.Classes;

internal abstract class Entity<T>
{
    internal required abstract Id<T> Id { get; init; }
}
