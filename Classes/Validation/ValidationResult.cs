
namespace TodoList.Domain.Classes.Validation;

internal readonly record struct ValidationResult(bool IsValid, IEnumerable<string> ValidationErrors);
