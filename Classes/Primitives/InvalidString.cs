
namespace TodoList.Domain.Classes.Primitives;

internal readonly record struct InvalidString(string Value, IEnumerable<string> ValidationErrors);
