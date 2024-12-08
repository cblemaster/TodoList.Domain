
using System.Text.RegularExpressions;

namespace TodoList.Domain.Primitives;

internal record ValidatableString(string Value, int MaxLength, bool IsRequired, bool IsAllowAllWhitespace)
{
    internal ValidString ThisAsValidString() => new(Value, MaxLength, IsRequired, IsAllowAllWhitespace);

    internal InvalidString ThisAsInvalidString(string validationError) => new(Value, MaxLength, IsRequired, IsAllowAllWhitespace, [validationError]);

    internal ValidatableString ValidateAndReturnValidStringOrInvalidString()
    {
        if (IsRequired && string.IsNullOrEmpty(Value))
        {
            return ThisAsInvalidString("Value is required");
        }
        else if (!IsAllowAllWhitespace && Regex.Match(Value, (@"[^\s+$]")).Success)
        {
            return ThisAsInvalidString("Value cannot consist of only whitespace characters.");
        }
        else if (Value.Length > MaxLength)
        {
            return ThisAsInvalidString($"Value must be {MaxLength} characters or fewer.");
        }
        return ThisAsValidString();
    }
}
