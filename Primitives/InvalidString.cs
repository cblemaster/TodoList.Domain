
namespace TodoList.Domain.Primitives;

internal record InvalidString(string Value, int MaxLength, bool IsRequired, bool IsAllowAllWhitespace, IEnumerable<string> ValidationErrors)
    : ValidatableString(Value, MaxLength, IsRequired, IsAllowAllWhitespace);
