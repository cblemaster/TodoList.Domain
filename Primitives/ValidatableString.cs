
using System.Text.RegularExpressions;

namespace TodoList.Domain.Primitives;

internal class ValidatableString
{
    internal required string Value { get; init; }
    internal required int MaxLength { get; init; }
    internal required bool IsRequired { get; init; }
    internal required bool IsAllowAllWhitespace { get; init; }

    internal ValidString ThisAsValidString() => new() { Value = Value, MaxLength = MaxLength, IsRequired = IsRequired, IsAllowAllWhitespace = IsAllowAllWhitespace };

    internal InvalidString ThisAsInvalidString(string validationError) => new() { Value = Value, MaxLength = MaxLength, IsRequired = IsRequired, IsAllowAllWhitespace = IsAllowAllWhitespace, ValidationErrors = [validationError] };

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
