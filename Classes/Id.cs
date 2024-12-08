
namespace TodoList.Domain.Classes;

internal class Id<T> : Identifier<T>
{
    private Guid _value;
    
    internal required override Guid Value { get => _value; init => _value = value; }
}
