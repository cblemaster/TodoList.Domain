
namespace TodoList.Domain.Classes.Primitives.BaseClasses;

internal abstract class Identifier<T>
{
    internal required abstract Guid Value { get; init; }
}
