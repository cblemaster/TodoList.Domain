
using System.Text.RegularExpressions;
using TodoList.Domain.ValueStructs;

namespace TodoList.Domain.Primitives;

internal record InvalidString(string Value, bool IsRequired, int? MaxLength, bool IsAllWhitespaceAllowed, ValidationResult ValidationResult) : ValidatableString(Value)
{
    internal ValidationResult ValidationResult { get; private set; } = ValidationResult;

    internal ValidatableString ValidateAndReturnValidStringOrInvalidString()
    {
        bool isValid = true;
        List<string> validationErrors = [];

        if (IsRequired && string.IsNullOrEmpty(Value))
        {
            isValid = false;
            validationErrors.Add("Value is required");
        }
        else if (MaxLength.HasValue && Value.Length > MaxLength.Value)
        {
            isValid = false;
            validationErrors.Add($"Value must be {MaxLength} characters or fewer");
        }
        else if (!IsAllWhitespaceAllowed && Regex.Match(Value, @"[^\s+$]").Success)
        {
            isValid = false;
            validationErrors.Add("Value cannot consist of only whitespace characters");
        }

        ValidationResult = new(isValid, validationErrors);
        return isValid ? (ValidString)(this as ValidatableString) : this;
    }
}
