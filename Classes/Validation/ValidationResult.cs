
namespace TodoList.Domain.Classes.Validation;

internal class ValidationResult
{
    internal required bool IsValid { get; set; }
    internal required IEnumerable<string> ValidationErrors { get; set; }
}
