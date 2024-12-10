
namespace TodoList.Domain;

internal readonly record struct ValidationResult(bool IsValid, IEnumerable<string> ValidationErrors);
