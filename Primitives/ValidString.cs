
namespace TodoList.Domain.Primitives;

internal record ValidString(string Value, int MaxLength, bool IsRequired, bool IsAllowAllWhitespace)
    : ValidatableString(Value, MaxLength, IsRequired, IsAllowAllWhitespace);
