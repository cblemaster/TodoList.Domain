
using System.Text.RegularExpressions;
using TodoList.Domain.Classes.Validation;

namespace TodoList.Domain.Classes.Primitives;

internal class ValidatableString
{
    internal required string Value { get; init; }
    internal bool IsRequired { get; init; }
    internal bool IsAllowAllCharsWhitespace { get; init; }
    internal int? MaxLength { get; init; }

    internal ValidationResult Validate()
    {
        bool isValid = true;
        List<string> errors = [];

        if (IsRequired && string.IsNullOrEmpty(Value))
        {
            isValid = false;
            errors.Add("Value is required.");
        }
        else if (!IsAllowAllCharsWhitespace && Regex.Match(Value, (@"[^\s+$]")).Success)
        {
            isValid = false;
            errors.Add("Value cannot be only whitespace characters.");
        }
        else if (MaxLength.HasValue && MaxLength.Value > 0 && Value.Length > MaxLength.Value)
        {
            isValid = false;
            errors.Add($"Value must be {MaxLength} characters or fewer.");
        }
        return new() { IsValid = isValid, ValidationErrors = errors.AsEnumerable() };
    }
}
