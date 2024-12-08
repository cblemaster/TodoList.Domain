
using TodoList.Domain.Classes.Primitives.BaseClasses;

namespace TodoList.Domain.Classes.Primitives;

internal class Id<T> : Identifier<T>
{
    private Guid _value;

    internal required override Guid Value { get => _value; init => _value = value; }
}
