
namespace TodoList.Domain.Classes;

internal abstract class Identifier<T>
{
    internal required abstract Guid Value { get; init; }
}
