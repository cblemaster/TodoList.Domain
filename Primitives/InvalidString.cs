
namespace TodoList.Domain.Primitives;

internal class InvalidString : ValidatableString
{
    internal required IEnumerable<string> ValidationErrors { get; init; }
}
