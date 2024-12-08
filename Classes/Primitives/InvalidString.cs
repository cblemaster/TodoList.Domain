
namespace TodoList.Domain.Classes.Primitives;

internal class InvalidString
{
    internal required string Value { get; init; }
    internal required IEnumerable<string> ValidationErrors { get; set; }
}
