
namespace TodoList.Domain.Classes.BaseClasses;

internal abstract class Identifier<T>
{
    internal required abstract Guid Value { get; init; }
}
